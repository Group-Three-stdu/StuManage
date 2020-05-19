using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CourseMes
    {
        public int CourseID { set; get; }
        public string CourseName { set; get; }
        public int TeaId { set; get; }
        public float Xuefen { set; get; }
        public int CourseNum { set; get; }
        public string courseproperty { set; get; }
        public string SStatus { set; get; }
        public string CollegeName { set; get; }

        //仅在教师查看课程中使用，表中无该字段
        public string Time { set; get; }
    }
}
