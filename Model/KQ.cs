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
        public DateTime KqTime { set; get; }
        public DateTime EndTime { set; get; }
        public  int StuNum { set; get; }

        //仅作排序使用 数据库表中没有此字段
        public int KQXh { get; set; }
    }
}
