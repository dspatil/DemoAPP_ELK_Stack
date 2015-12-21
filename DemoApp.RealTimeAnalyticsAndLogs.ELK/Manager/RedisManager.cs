using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoApp.RealTimeAnalyticsAndLogs.ELK.Models;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Jil;

namespace DemoApp.RealTimeAnalyticsAndLogs.ELK.Manager
{
    public static class RedisManager
    {
        public static void AddItem(UserModel user)
        {
            using (var redisClient = new StackExchangeRedisCacheClient(new JilSerializer()))
            {
                redisClient.ListAddToLeft("RedisLoggingQueue", user);
            }
        }
    }
}