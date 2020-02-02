
namespace CgxmlToCsv.Logger
{
    public abstract class LogBase
   {
        /// <summary>
        /// Used to lock an object in order to be thread safe
        /// </summary>
        protected readonly object PadLock = new object();

        public virtual void Write(string message) { }
    }
}
