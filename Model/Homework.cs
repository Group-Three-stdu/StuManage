﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Homework
    {
        public string Hwid { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public string HwContent { set; get; }
    }
}
