using DesignPattern_Observable.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern_Observable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                 throw new ArgumentNullException();
            }
            catch (Exception ex)
            {

                Logger.Instance.Error(ex.Message);
                
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}