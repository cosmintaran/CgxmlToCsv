namespace CgxmlToCsv.Logger
{
    public class ConsoleLogger : LogBase
    {
        public delegate void OutputLogingEventHandler(string msg);
        public static event OutputLogingEventHandler OnNewLoggin;

        public string Message { get; private set; }


        public override void Write(string msg)
        {
            lock (PadLock)
            {

                OnNewLoggin?.Invoke(msg);
            }
        }
    }
}