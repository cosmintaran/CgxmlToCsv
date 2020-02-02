
//using System.Diagnostics;

namespace CgxmlToCsv.Logger
{
    public static class LogHelper
    {
        private static LogBase logger;

        private static readonly object Padlock = new object();

        public static void Log(LogTarget target, string message)
        {
            logger = GetInstance(target);
            logger?.Write(message);
        }


        private static LogBase GetInstance(LogTarget target)
        {
            lock (Padlock)
            {
                switch (target)
                {
                    case LogTarget.File:
                        {
                           // logger = new FileLogger();
                        }
                        break;
                    case LogTarget.Console:
                        {
                            logger = new ConsoleLogger();
                        }
                        break;

                    case LogTarget.EventLog:
                        {
                           // logger = new EventLogger();
                        }
                        break;

                    default:
                        return null;
                }
            }

            return logger;
        }
    }

    /// <summary>
    /// Defines place to put the log
    /// </summary>
    public enum LogTarget
    {
        Console = 0,
        File = 1,
        EventLog = 2
    }
}

