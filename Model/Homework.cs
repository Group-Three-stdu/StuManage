using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Homework
    {
        public int HwId { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public string HwContent { set; get; }
        public int CourseId { set; get; }
        public string HwHead { set; get; }
    }
}
