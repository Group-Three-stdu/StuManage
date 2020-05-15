using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Score
    {
        public int StuId { set; get; }
        public int CourseId { set; get; }
        public float  ClassScore { set; get; }
        public float MatchScore { set; get; }
        public float FinalScore { set; get; }
    }
}
