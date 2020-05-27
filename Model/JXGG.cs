using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class JXGG
    {
        public int Id { set; get; }
        public int xh { set; get; }
        public string GGHead { set; get; }
        public string GGContent { set; get; }
        public int TeaId { set; get; }
        public DateTime Time { set; get; }
        public int CourseId { set; get; }
        public string TeaName { set; get; }
    }
}
