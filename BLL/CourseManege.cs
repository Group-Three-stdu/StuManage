using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class CourseManege
    {
        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="CourseId">课程编号</param>
        /// <param name="Selected_courseid">选课编号</param>
        /// <returns>1成功，-1必修不可删除 ，0失败</returns>
        public int DeleteSelectedCourse(int CourseId,string Selected_courseid)
        {
            int result = new CourseService().queryCouresProperty(CourseId);
            if (result == 0)
                return -1;
            return new CourseService().deleteSelectedCourse(Selected_courseid);
        }

        /// <summary>
        /// 增加课程
        /// </summary>
        /// <param name="course">课程对象（包含课程名、课程性质、学分、课时数）</param>
        /// <returns>1成功</returns>
        public int AddCourseByTea(CourseMes course)
        {
            return new CourseService().addCourse(course);
        }

        /// <summary>
        /// 显示所有待审核的课程
        /// </summary>
        /// <returns>课程集合</returns>
        public List<CourseMes> showUncheck()
        {
            return new CourseService().showUncheck();
        }


        /// <summary>
        /// 通过审核
        /// </summary>
        /// <param name="CourseId">审核课程的课程编号</param>
        /// <param name="courseExt">教务处新增信息</param>
        /// <returns>1成功，0失败</returns>
        public int checkCourseToY(int CourseId,CourseMana courseExt)
        {
            int result1 = new CourseService().checkCourseY(CourseId);
            if (result1 == 0)
                return result1;
            CourseMes course = new CourseService().queryCourseById(CourseId);
            return new CourseService().addCoursetoMana(course, courseExt);
            
        }

        /// <summary>
        /// 未通过审核
        /// </summary>
        /// <param name="CourseId">审核课程的课程编号</param>
        /// <returns>1成功，0失败</returns>
        public int checkCourseToN(int CourseId)
        {
            return new CourseService().checkCourseN(CourseId);
        }

        /// <summary>
        /// 查询所有课程（选课）
        /// </summary>
        /// <returns></returns>
        public List<CourseMana> queryAllCourse()
        {
            return new CourseService().queryAllCourse();
        }

        /// <summary>
        /// 查询自己选择的课程
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<CourseMana> queryMyCourse(int StuId)
        {
            return new CourseService().queryCourseByStuId(StuId);
        }


    }
}
