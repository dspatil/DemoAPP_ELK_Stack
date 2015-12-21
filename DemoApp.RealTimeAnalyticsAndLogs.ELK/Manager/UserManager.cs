using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoApp.RealTimeAnalyticsAndLogs.ELK.Models;

namespace DemoApp.RealTimeAnalyticsAndLogs.ELK.Manager
{
    public static class UserManager
    {
        public static void RegisterUser(UserModel user)
        {
            RedisManager.AddItem(user);
        }
    }
}