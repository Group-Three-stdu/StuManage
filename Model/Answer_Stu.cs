using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Answer_Stu
    {
        public int StuId { set; get; }
        public int HwId { set; get; }
        public string Answer { set; get; }
        public string Grade { set; get; }
        public  string Resist { set; get; }
        public DateTime Time { set; get; }
        public string HwState { set; get; }
        //--
        public string StuName { set; get; }
        public string ClassId { set; get; }
    }
}
