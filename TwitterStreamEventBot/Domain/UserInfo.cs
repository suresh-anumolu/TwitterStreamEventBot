﻿using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterStreamEventBot.Domain
{
    public static class UserInfo
    {
        //get id for user
        //dump in application state/db
        //public static List<Topic> topicList { get; set; }
        //public static HashSet<string> topicNames { get; set; }
        //public static Dictionary<string, Dictionary<ChannelAccount, DateTime>> topicDict { get; set; }
        public static Dictionary<string, Dictionary<BotUserChannel, DateTime>> topicDict2 { get; set; }
    }
}