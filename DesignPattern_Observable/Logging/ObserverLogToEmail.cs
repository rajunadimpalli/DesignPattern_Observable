using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace DesignPattern_Observable.Logging
{
    // sends log events via email.
    public class ObserverLogToEmail : ILog
    {
        private string from;
        private string to;
        private string subject;
        private string body;
        private SmtpClient smtpClient;

        public ObserverLogToEmail(string from, string to, string subject, string body, SmtpClient smtpClient)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
            this.body = body;

            this.smtpClient = smtpClient;
        }

        #region ILog Members
        public void Log(object sender, LogEventArgs e)
        {
            string message = "[" + e.Date.ToString() + "] " + ": " + e.Message;
            // commented out for now. you need privileges to send email.
            // _smtpClient.Send(from, to, subject, body);
        }
        #endregion
    }
}