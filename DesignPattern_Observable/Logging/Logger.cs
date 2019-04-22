using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern_Observable.Logging
{
    // Design patterns: Singleton, Observer.
    public sealed class Logger
    {
        // delegate event handler that hooks up requests.
        public delegate void LogEventHandler(object sender, LogEventArgs e);
        // the log event
        public event LogEventHandler Log;

        #region The Singleton definition
        // the one and only singleton logger instance
        // the one and only Singleton Logger instance. 

        private static readonly Logger instance = new Logger();
        private Logger()
        {

        }
        // gets the instance of the singleton logger object

        public static Logger Instance
        {
            get { return instance; }
        }
        #endregion


        public void Error(string message)
        {
            Error(message, null);
        }

        // log a message when severity level is "Error" or higher.

        public void Error(string message, Exception exception)
        {
            OnLog(new LogEventArgs(message, exception, DateTime.Now));
        }

        // invoke the log event
        public void OnLog(LogEventArgs e)
        {
            if (Log != null)
            {
                Log(this, e);
            }
        }
        // attach a listening observer logging device to logger
        public void Attach(ILog observer)
        {
            Log += observer.Log;
        }

        // detach a listening observer logging device from logger
        public void Detach(ILog observer)
        {
            Log += observer.Log;
        }
    }
}