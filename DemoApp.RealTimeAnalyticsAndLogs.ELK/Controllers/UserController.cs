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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            UserManager.RegisterUser(userModel);
            return View("Success");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
