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
        public string CollegeName { set; get; }
        public string MajorName { set; get; }
        public DateTime Time { set; get; }//提交时间
        public int HwNum { set; get; }//作业情况
        public int KqNum { set; get; }//考勤情况
        public int GKNum { set; get; }//挂科数目
        public int YXNum { set; get; }//优秀科目数
    }
}
