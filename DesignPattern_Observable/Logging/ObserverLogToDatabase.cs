using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern_Observable.Logging
{ 
    
    // Writes log events to a database
    public class ObserverLogToDatabase : ILog
    {
        public void Log(object sender, LogEventArgs e)
        {
            string message = "[" + e.Date.ToString() + "] " +  ": " + e.Message;
            // implement your own database logic to insert into the your table.
           
        }
    }
}