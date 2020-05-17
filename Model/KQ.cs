using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class KQ
    {
        public int KQId { set; get; }
        public int CourseId { set; get; }
        public string ClassId { set; get; }
        public DateTime KqTime { set; get; }
        public  string StuState { set; get; }
    }
}
