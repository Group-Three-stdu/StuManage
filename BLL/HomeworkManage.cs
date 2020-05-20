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
    }
}
