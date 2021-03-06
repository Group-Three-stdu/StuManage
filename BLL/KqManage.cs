﻿using System;
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
            //判断是否超时
            DateTime nowtime = DateTime.Now;
            DateTime EndTime = new KqService().queryEndTime(KQId);
            if (DateTime.Compare(nowtime, EndTime) > 0)
                return -2;
            int result2 = new KqService().AddKqRecord(StuId, KQId, time);
            if (result2 <= 0)
                return 0;
            return new KqService().UpdateStuNum(KQId);
        }


        /// <summary>
        ///查看未签到学生的信息
        /// </summary>
        /// <param name="KQId"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Students> queryUncheckStu(int KQId, int CourseId)
        {
            List<Students> stuIdList = new KqService().queryUnCheckStuId(KQId, CourseId);
            List<Students> stuList = new List<Students>();
            foreach (Students stu in stuIdList)
            {
                stuList.Add(new StudentService().queryStuById(stu.StuId));
            }
            return stuList;
        }

        /// <summary>
        /// 查询已签到的学生学号姓名
        /// </summary>
        /// <param name="KQId"></param>
        /// <returns></returns>
        public List<Students> queryCheckedStu(int KQId)
        {
            return new KqService().queryCheckedStu(KQId);
        }
        /// <summary>
        /// 查看考勤次数
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public int queryStuKqNum(int StuId, int CourseId)
        {
            return new KqService().queryStuKqNum(StuId, CourseId);
        }

        //查询学生是否已签到
        public int HasChecked(int StuId, int KQId)
        {
            return new KqService().HasChecked(StuId, KQId);
        }
    }
}
