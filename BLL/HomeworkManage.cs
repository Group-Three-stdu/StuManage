using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class HomeworkManage
    {
        /// <summary>
        /// 学生端，显示该学生所有的课程
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<Homework> ShowStuHK(int CourseId)
        {
            return new HomeworkService().queryHKByStuId(CourseId);
        }

        /// <summary>
        /// 查看作业详情
        /// </summary>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public Homework ShowHwDetail(int HwId)
        {
            return new HomeworkService().queryHkByHkId(HwId);
        }

        /// <summary>
        /// 学生提交作业
        /// </summary>
        /// <param name="ans"></param>
        /// <returns></returns>
        public int SubmitHw(Answer_Stu ans)
        { 
            int res = new HomeworkService().queryHasSubmited(ans.StuId, ans.HwId);
            if (res > 0)
                return -1;
            int result = new HomeworkService().SubmitHw(ans);
            if (result > 0)
                return new HomeworkService().alterFinishNum(ans.HwId);
            return result;
        }

        /// <summary>
        /// 教师查看课程的所有作业
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Homework> queryAllHKByTea(int CourseId)
        {
            return new HomeworkService().queryAllHKByTea(CourseId);
        }

        /// <summary>
        /// 教师发布作业
        /// </summary>
        /// <param name="hw"></param>
        /// <returns></returns>
        public int fabuHw(Homework hw)
        {
            return new HomeworkService().fabuHw(hw);
        }

        public List<Answer_Stu> querySubmitedStu(int HwId)
        {
            return new HomeworkService().querySubmitedStu(HwId);
        }

        /// <summary>
        /// 查询未提交作业的学生信息
        /// </summary>
        /// <param name="HwId"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Students> queryUnsubmitStuId(int HwId, int CourseId)
        {
            List<Students> stuIdList = new HomeworkService().queryUnsubmitStuId(HwId, CourseId);
            List<Students> stuList = new List<Students>();
            foreach (Students stu in stuIdList)
            {
                stuList.Add(new StudentService().queryStuById(stu.StuId));
            }
            return stuList;
        }

        /// <summary>
        /// 查询学生的答案
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public Answer_Stu queryStuAnsByStuId(int StuId, int HwId)
        {
            return new HomeworkService().queryStuAnsByStuId(StuId, HwId);
        }

        /// <summary>
        /// 教师批阅作业
        /// </summary>
        /// <param name="Grade"></param>
        /// <param name="Resist"></param>
        /// <param name="StuId"></param>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public int TeaCheckAns(string Grade, string Resist, int StuId, int HwId)
        {
            int result = new HomeworkService().TeaCheckAns(Grade,Resist,StuId, HwId);
            if (result > 0)
                return new HomeworkService().TeaChangeAnsSta(StuId, HwId);
            else return 0;
        }
    }
}
