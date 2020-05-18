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

        /// <summary>
        /// 学生完成签到
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="KQId"></param>
        /// <param name="time"></param>
        /// <returns>返回1表示签到成功，返回-1表示已经签到</returns>
        public int AddKqRecord(int StuId, int KQId, DateTime time)
        {
            int result1 = new KqService().IsAttend(StuId, KQId);
            if (result1 != 0)
                return -1;
            int result2 = new KqService().AddKqRecord(StuId, KQId, time);
            if (result2 <= 0)
                return 0;
            return new KqService().UpdateStuNum(KQId);
        }
    }
}
