using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern_Observable.Logging
{
    /// <summary>
    /// Contains log specific event data for log events.
    /// </summary>
    public class LogEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of LogEventArgs.
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="exception">Inner exception.</param>
        /// <param name="date">Log date.</param>
        public LogEventArgs(string message, Exception exception, DateTime date)
        {
            Message = message;
            Exception = exception;
            Date = date;
        }

        /// <summary>
        /// Gets and sets the log message.
        /// </summary>        
        public string Message { get; private set; }

        /// <summary>
        /// Gets and sets the optional inner exception.
        /// </summary>        
        public Exception Exception { get; private set; }

        /// <summary>
        /// Gets and sets the log date and time.
        /// </summary>        
        public DateTime Date { get; private set; }

        /// <summary>
        /// LogEventArgs as a string representation.
        /// </summary>
        /// <returns>String representation of the LogEventArgs.</returns>
        public override String ToString()
        {
            return "" + Date
                + " - " + Message
                + " - " + Exception.ToString();
        }
    }
}