using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Students
    {
        public int StuId { set; get; }
        public string StuName { set; get; }
        public string StuSex { set; get; }
        public string StuBirth { set; get; }
        public string StuNoId { set; get; }
        public string StuPhoneNum { set; get; }
        public string StuAdd { set; get; }
        public string ClassId { set; get; }
        public string StuHonor { set; get; }
        public string Major { set; get; }
        public string College { set; get; }
        public string StuState { set; get; }
        public string Punish { set; get; }
        public string PoliticalStatus { set; get; }

        //临时使用，数据库中没有该字段
        public DateTime Time { set; get; }
    }
}
