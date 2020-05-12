using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CourseMana : CourseMes
    {
        public string Season { set; get; }
        public string Time { set; get; }
        public string CourseAdd { set; get; }
        public float MatchRatio { set; get; }
        public float ClassRatio { set; get; }
    }
}
