using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ScoreExt:Students
    {
        public float MatchScore { set; get; }
        public float ClassScore { set; get; }
        public float FinalScore { set; get; }
        public int CourseId { set; get; }
        public float Xuefen { set; get; }
        public string CollegeName { set; get; }
        public string CourseName { set; get; }
    }
}
