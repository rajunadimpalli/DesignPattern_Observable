using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DesignPattern_Observable.Logging; // get logging reference

namespace DesignPattern_Observable
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            InitializeLogger();
        }

        private void InitializeLogger()
        {
            // send log messages to email (observer pattern)
            string from = "notification@yourcompany.com";
            string to = "webmaster@yourcompany.com";
            string subject = "Webmaster: please review";
            string body = "email text";
            var smtpClient = new SmtpClient("mail.yourcompany.com");
           
            var logEmail = new ObserverLogToEmail(from, to, subject, body, smtpClient);
            Logger.Instance.Attach(logEmail);

            // send log messages to a file

            var logFile = new ObserverLogToFile(@"C:\Temp\Error.log");
            Logger.Instance.Attach(logFile);

            // send log messages to database (observer pattern)

            var logDatabase = new ObserverLogToDatabase();
            Logger.Instance.Attach(logDatabase);
        }


        // this is the last-resort exception handler.
        // it uses te logging infrastructure to log the error details.
        // the application will then be redirected according to the 
        // customErrors configuration in web.config.

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError().GetBaseException();

            // NOTE: commented out because the site needs authorization to logging resources.
             Logger.Instance.Error(exception.Message);

            // <customErrors ..> in web config will now redirect.
        }
    }
}
