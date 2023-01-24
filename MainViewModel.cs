
using CgxmlToCsv.Logger;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace CgxmlToCsv
{
    public class MainViewModel : ObservableObject
    {


        #region Attributes

        private string[] _cgxmlFolderPath;
        private string _csvPath;
        private bool _multipleImport;
        private int _progressPercentage;
        private string _output;
        private bool _startEnabled;
        private bool _cancelEnabled;
        private readonly BackgroundWorker _worker;
        private DispatcherTimer timer;
        private string elapsedTime;
        private long seconds;
        private static readonly object Padlock = new object();
        private string _cancelMessage;


        #endregion

        #region Properties

        public bool ImportMultiple
        {
            get { return _multipleImport; }
            set
            {
                _multipleImport = value;
                NotifyPropertyChanged();
            }
        }

        public string Output
        {
            get { return _output; }

            set
            {
                if (_output == value) return;

                _output = value;
                NotifyPropertyChanged();
            }
        }

        public int ProgressPercentage
        {
            get { return _progressPercentage; }

            set
            {
                if (_progressPercentage == value) return;

                _progressPercentage = value;
                NotifyPropertyChanged();
            }

        }

        public bool StartEnabled
        {
            get { return _startEnabled; }

            set
            {
                if (_startEnabled == value) return;

                _startEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public bool CancelEnabled
        {
            get { return _cancelEnabled; }

            set
            {
                if (_cancelEnabled == value) return;

                _cancelEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public string CSVPath
        {
            get { return _csvPath; }
            set
            {
                _csvPath = value;
                NotifyPropertyChanged();
            }
        }

        public string CgxmlPath
        {
            get
            {
                if (_cgxmlFolderPath == null) return string.Empty;
                if (_multipleImport)
                    return _cgxmlFolderPath[0];

                if (_cgxmlFolderPath.Length < 2)
                    return _cgxmlFolderPath[0];

                string retVal = string.Empty;

                foreach (var f in _cgxmlFolderPath)
                    retVal += Path.GetFileName(f);

                return retVal;
            }
        }

        public ObservableCollection<string> ConsoleOutput { get; }

        public string ElapsedTime
        {
            get { return elapsedTime; }
            set
            {
                elapsedTime = value;
                NotifyPropertyChanged();
            }
        }
        #endregion


        public MainViewModel()
        {
            _startEnabled = true;
            _cancelEnabled = false;
            ConsoleOutput = new ObservableCollection<string>();

            _worker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _worker.DoWork += worker_DoWork;
            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        #region Methods

        private CGXML ReadCGXML(string filePath)
        {
            CGXML cgxml = null;
            var deserializer = new XmlSerializer(typeof(CGXML));
            try
            {
                using (var reader = new XmlTextReader(filePath))
                {
                    if (deserializer.CanDeserialize(reader))
                        cgxml = (CGXML)deserializer.Deserialize(reader);
                    else
                        throw new ImportCGXMLException(string.Format("Fisierul {0} CGXML nu poate fi deserializat, Eroare de structura."
                            , Path.GetFileName(filePath)), null);
                }
            }
            catch (Exception ex)
            {
                throw new ImportCGXMLException(string.Format("Exceptie aruncata de XmlSerializer in functia ReadCGXML pentru fisierul {0} ", Path.GetFileName(filePath)),
                    ex.InnerException);
            }

            return cgxml;
        }

        private void BrowseCsvFile()
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog()
            {

                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Select csv file",
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = ".csv",
                Filter = "Csv files (*.csv)|*.csv|All files(*.*)|*.*",
                RestoreDirectory = false,
                OverwritePrompt = true,
            };

            var ok = sfd.ShowDialog();
            if (ok == null || ok == false)
            {
                return;
            }
            CSVPath = sfd.FileName;
        }

        private void BrowseCgxmlFile()
        {
            if (_multipleImport)
            {
                var dialog = new FolderBrowserDialog()
                {
                    Description = @"Select CGXML folder path",
                    ShowNewFolderButton = false
                };
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    System.Windows.MessageBox.Show(@"Atentie nu a fost selectat nici un folder", @"Warning", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }
                _cgxmlFolderPath = new string[1];
                _cgxmlFolderPath[0] = dialog.SelectedPath;

                NotifyPropertyChanged("CgxmlPath");
            }

            else
            {
                Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog()
                {

                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    Title = "Select Cgxml file",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = ".cgxml",
                    Filter = "Cgxml files (*.cgxml)|*.cgxml|All files(*.*)|*.*",
                    RestoreDirectory = false,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true,
                    Multiselect = true
                };

                var ok = ofd.ShowDialog();
                if (ok == null || ok == false)
                {
                    //System.Windows.MessageBox.Show("No file selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                _cgxmlFolderPath = ofd.FileNames;
                NotifyPropertyChanged("CgxmlPath");
            }
        }

        private void StartProcess()
        {
            Output = "";
            if (!_worker.IsBusy)
            {

                timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 1) };
                timer.Tick += TimerTick;

                _worker.RunWorkerAsync();
                seconds = 0;
                timer.Start();
            }

            StartEnabled = !_worker.IsBusy;
            CancelEnabled = _worker.IsBusy;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            ++seconds;
            ElapsedTime = string.Format("Time elapsed: {0}:{1}:{2}", (int)seconds / 3600, (int)seconds / 60 % 60, seconds % 60);
        }

        private void CancelProcess()
        {
            if (_worker.IsBusy)
                _worker.CancelAsync();
            timer.Stop();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: {1}",
                    DateTime.Now.ToString(CultureInfo.InvariantCulture), e.Error.Message)));

            else if (e.Cancelled)
                DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0} {1}:",
                  DateTime.Now.ToString(CultureInfo.InvariantCulture), _cancelMessage)));
            else
            {
                ProgressPercentage = 0;
                DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: Numar total de fisiere importate {1}.", DateTime.Now.ToString(CultureInfo.InvariantCulture), e.Result)));
            }

            StartEnabled = !_worker.IsBusy;
            CancelEnabled = _worker.IsBusy;
            timer.Stop();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressPercentage = e.ProgressPercentage;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var result = 0;

            if (worker == null)
            {
                DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: Error starting the import cgxml module (worker is null)",
                    DateTime.Now.ToString(CultureInfo.InvariantCulture))));
                return;
            }

            StreamWriter streamWriter = null;
            StringBuilder builder = null;
            string[] files = null;
            try
            {

                if (_cgxmlFolderPath == null)
                {
                    e.Cancel = true;
                    return;
                }

                files = _multipleImport == true ? Directory.GetFiles(_cgxmlFolderPath[0]) : _cgxmlFolderPath;

                streamWriter = new StreamWriter(_csvPath);
                builder = new StringBuilder();
                builder.AppendLine("Land_Nr. CF(hartie), Land_Nr.CAD, Land_Topo, Intravilan, ID Eterra, Supraf. Acte, Supraf Mas, CadGenId, Nr.Titlu, Nr. Tarla, Mentiuni parcela, Parcel_Topo, PARCELNO, Proprietar");
                streamWriter.Write(builder);
            }
            catch (Exception ex)
            {

                ////DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("Error: {0}",ex.Message)));
                _cancelMessage = ex.Message;
                e.Cancel = true;
                return;
            }

            for (var i = 0; i < files.Length; ++i)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                try
                {
                    if (string.Compare(Path.GetExtension(files[i]), ".cgxml", true, CultureInfo.InvariantCulture) != 0) continue;
                    CGXML cg = ReadCGXML(files[i]);
                    if (cg == null)
                    {
                        DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: Eroare citire fisier {1}", DateTime.Now.ToString(CultureInfo.InvariantCulture)
                        , Path.GetFileName(files[i]))));
                        continue;
                    }
                    builder.Clear();

                    if (cg.Land != null)
                    {
                        builder.Append(RemoveSpecialCharFromString(cg.Land.PAPERLBNO?.Trim()));
                        builder.Append(",");
                        builder.Append(RemoveSpecialCharFromString(cg.Land.PAPERCADNO?.Trim()));
                        builder.Append(",");
                        builder.Append(RemoveSpecialCharFromString(cg.Land.TOPONO?.Trim()));
                        builder.Append(",");
                        var adress =cg.Address.FirstOrDefault(w => w.ADDRESSID == cg.Land.ADDRESSID);
                        if (adress != null)
                            builder.Append(RemoveSpecialCharFromString(adress.INTRAVILAN.ToString()));
                        else
                            builder.Append("");
                        builder.Append(",");
                        builder.Append(RemoveSpecialCharFromString(cg.Land.E2IDENTIFIER?.Trim()));
                        builder.Append(",");
                        builder.Append(cg.Land.PARCELLEGALAREA);
                        builder.Append(",");
                        builder.Append(cg.Land.MEASUREDAREA);
                        builder.Append(",");
                        builder.Append(RemoveSpecialCharFromString(cg.Land.CADGENNO?.Trim()));
                        builder.Append(",");
                        //TODO add registration
                    }
                    else
                    {
                        builder.Append(",,,,,,,");
                    }

                    if (cg.Parcel != null)
                    {
                        StringBuilder tarla = new StringBuilder();
                        StringBuilder titlu = new StringBuilder();
                        StringBuilder mentiuni = new StringBuilder();
                        StringBuilder parcelTopo = new StringBuilder();
                        StringBuilder parcelNo = new StringBuilder();

                        foreach (var p in cg.Parcel)
                        {
                            if (!string.IsNullOrEmpty(p.LANDPLOTNO))
                                tarla.Append(RemoveSpecialCharFromString(p.LANDPLOTNO?.Trim()) + "; ");

                            if (!string.IsNullOrEmpty(p.TITLENO))
                                titlu.Append(RemoveSpecialCharFromString(p.TITLENO?.Trim()) + "; ");

                            if (!string.IsNullOrEmpty(p.NOTES))
                                mentiuni.Append(RemoveSpecialCharFromString(p.NOTES?.Trim()) + "; ");


                            if (!string.IsNullOrEmpty(p.TOPONO))
                                parcelTopo.Append(RemoveSpecialCharFromString(p.TOPONO?.Trim()) + "; ");


                            if (!string.IsNullOrEmpty(p.PARCELNO))
                                parcelNo.Append(RemoveSpecialCharFromString(p.PARCELNO?.Trim(),"_") + "; ");
                        }

                        var titluStr = titlu?.ToString().TrimEnd(' ', ';');
                        var tarlaStr = tarla?.ToString().TrimEnd(' ', ';');
                        var mentiuniStr = mentiuni?.ToString().TrimEnd(' ', ';');

                        var parcelTopoStr = parcelTopo?.ToString().TrimEnd(' ', ';');
                        var parcelNoStr = parcelNo?.ToString().TrimEnd(' ', ';', '_');

                        builder.Append(titluStr);
                        builder.Append(",");
                        builder.Append(tarlaStr);
                        builder.Append(",");
                        builder.Append(mentiuniStr);
                        builder.Append(",");
                        builder.Append(parcelTopoStr);
                        builder.Append(",");
                        builder.Append(parcelNoStr);
                        builder.Append(",");

                    }
                    else
                    {
                        builder.Append(",,,");
                    }

                    if (cg.Person != null)
                    {
                        StringBuilder nume = new StringBuilder();
                        foreach (var p in cg.Person)
                        {
                            if (!string.IsNullOrEmpty(p.FIRSTNAME) || !string.IsNullOrEmpty(p.LASTNAME))
                            {
                                p.FIRSTNAME = RemoveSpecialCharFromString(p.FIRSTNAME);
                                p.LASTNAME = RemoveSpecialCharFromString(p.LASTNAME); ;
                                nume.AppendFormat("{0} {1}", p.FIRSTNAME?.Trim(), p.LASTNAME?.Trim());
                            }
                        }

                        var numeStr = nume?.ToString().TrimEnd();

                        if (numeStr.EndsWith(";"))
                            numeStr.Remove(numeStr.Length - 1, 1);

                        builder.Append(numeStr);
                    }
                    streamWriter.WriteLine(builder);
                    DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: Fisierul {1} importat cu succes", DateTime.Now.ToString(CultureInfo.InvariantCulture),
                        Path.GetFileName(files[i]))));
                }
                catch (Exception ex)
                {
                    DispatchService.Invoke(() => ConsoleOutput.Add(string.Format("{0}: Eroare citire fisier {1}. {2}", DateTime.Now.ToString(CultureInfo.InvariantCulture)
                    , Path.GetFileName(files[i]), ex.Message)));
                    continue;
                }

                if (worker.WorkerReportsProgress)
                    worker.ReportProgress((i + 1) * 100 / files.Length);

                result = i + 1;
            }

            e.Result = result;
            streamWriter.Close();
        }

        private static string RemoveSpecialCharFromString(string str, string replaceChar=" ")
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            str = str.Replace("\r\n", " ");
            str = str.Replace("\n", " ");
            str = str.Replace(",", replaceChar);
            return str;
        }

        #endregion

        #region Commands

        public ICommand SelectCgxmlPathCmd { get { return new Command(s => BrowseCgxmlFile(), e => true); } }
        public ICommand SelectCsvPathCmd { get { return new Command(s => BrowseCsvFile(), e => true); } }

        public ICommand ImportCGXMLCmd { get { return new Command(s => StartProcess(), e => _cgxmlFolderPath != null && !string.IsNullOrEmpty(_csvPath)); } }
        public ICommand CancelCmd
        {
            get { return new Command(x => CancelProcess(), y => true); }
        }
        #endregion
    }
}
