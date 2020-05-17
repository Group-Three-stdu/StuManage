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
    }
}
