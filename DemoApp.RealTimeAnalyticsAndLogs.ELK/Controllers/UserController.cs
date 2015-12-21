using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApp.RealTimeAnalyticsAndLogs.ELK.Manager;
using DemoApp.RealTimeAnalyticsAndLogs.ELK.Models;

namespace DemoApp.RealTimeAnalyticsAndLogs.ELK.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserRegistration(UserModel userModel)
        {
            UserManager.RegisterUser(userModel);
            return View("Index");
        }
    }
}
