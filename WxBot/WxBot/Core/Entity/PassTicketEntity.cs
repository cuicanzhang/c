﻿using System;

namespace WxBot.Core.Entity
{
    /// <summary>
    /// 登陆后
    /// </summary>
    [Serializable]
    public class PassTicketEntity
    {
        public string WxSid { get; set; }

        public string WxUin { get; set; }

        public string SKey { get; set; }

        public string PassTicket { get; set; }
        public string WxHost { get; set; } 
    }
}
