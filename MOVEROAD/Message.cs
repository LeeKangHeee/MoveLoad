﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    public class Message
    {
        public string from_id { get; set; }
        public string to_id { get; set; }
        public string messege { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public int index { get; set; }
        public int reads { get; set; }
        
        

        public Message(string from, string to, string title, string messege, int index, DateTime date, int read)
        {
            this.from_id = from;
            this.to_id = to;
            this.title = title;
            this.messege = messege;
            this.index = index;
            this.date = date;
            this.reads = read;
        }
    }
}
