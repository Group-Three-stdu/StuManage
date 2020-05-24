using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Score:CourseMes
    {
        public int StuId { set; get; }
        public int CourseId { set; get; }
        public float  ClassScore { set; get; }
        public float MatchScore { set; get; }
        public float FinalScore { set; get; }
        public int SCID { set; get; }
        //数据库中没有一下字段，仅在此类中储存信息
        public int TeaId { set; get; }
        public string TeaName { set; get; }
    }
}
