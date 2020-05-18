using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class KqManage
    {
        /// <summary>
        /// 查询某一课程所有的考勤
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<KQ> queryAllKq(int CourseId)
        {
            return new KqService().queryAllKq(CourseId);
        }

        /// <summary>
        /// 发布考勤
        /// </summary>
        /// <param name="kq"></param>
        /// <returns></returns>
        public int publishAttendance(KQ kq)
        {
            return new KqService().publishAttendance(kq);
        }
    }
}
