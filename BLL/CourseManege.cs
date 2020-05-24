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
        /// <param name="StuId">学生学号</param>
        /// <returns>课程集合 </returns>
        public List<CourseMana> queryMyCourse(int StuId)
        {
            return new CourseService().queryCourseByStuId(StuId);
        }

        /// <summary>
        /// 显示所有通过审核的课程
        /// </summary>
        /// <returns>课程集合</returns>
        public List<CourseMes> showChecked()
        {
            return new CourseService().showChecked();
        }

        /// <summary>
        /// 学生选课
        /// </summary>
        /// <param name="CourseId">被选课程Id</param>
        /// <param name="StuId">学生Id</param>
        /// <returns>1 成功 </returns>
        public int chooseCourse(int CourseId,int StuId)
        {

            Course_Stu course = new Course_Stu();
            CourseMes course1 = new CourseService().queryCourseById(CourseId);
            CourseMana course2 = new CourseService().selectCourseById(CourseId);
            course.StuId = StuId;
            course.CourseId = course1.CourseID;
            course.TeaId = course1.TeaId;
            course.CourseName = course1.CourseName;
            course.Season = course2.Season;
            course.Time = course2.Time;
            return new CourseService().chooseCourse(course);
        }

        /// <summary>
        /// 查看已选课程
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<Course_Stu> showSelectCourse(int StuId)
        {
            return new CourseService().showSelectedCourse(StuId);
        }

        /// <summary>
        /// 按姓名模糊查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<CourseMana> queryCourseByName(string Name)
        {
            return new CourseService().queryCourseByName(Name);
        }

        /// <summary>
        /// 查询课程的信息
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<CourseMana> queryAllCourseByStuId(int StuId)
        {
            return new CourseService().queryCourseInfoByStuId(StuId);
        }

        /// <summary>
        /// 查询教师的课程
        /// </summary>
        /// <param name="TeaId"></param>
        /// <returns></returns>
        public List<CourseMes> queryTeaCourse(int TeaId)
        {
            return new CourseService().queryCourseInfoByTeaId(TeaId);
        }

        /// <summary>
        /// 查询某一课程的所有班级
        /// </summary>
        /// <param name="CourseId">被查询课程的编号</param>
        /// <returns>班级集合</returns>
        public List<Class> queryClassByCourseId(int CourseId)
        {
            return new CourseService().queryClassByCourseId(CourseId);
        }

        /// <summary>
        /// 增加课程的考试计分信息
        /// </summary>
        /// <param name="CourseId"></param>
        /// <param name="MatchRatio"></param>
        /// <param name="ClassRatio"></param>
        /// <returns></returns>
        public int AddRatio(int CourseId, float MatchRatio, float ClassRatio)
        {
            return new CourseService().AddRatio(CourseId, MatchRatio, ClassRatio);
        }

        /// <summary>
        /// 查询某门课程的总人数
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public int QueryStuNum(int courseId)
        {
            return new CourseService().QueryStuNum(courseId);
        }

        /// <summary>
        /// 查询课程信息
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public CourseMes queryCourseById(int CourseId)
        {
            return new CourseService().queryCourseById(CourseId);
        }

        /// <summary>
        /// 查询该学生所有的学期
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<CourseMana> querySeason(int StuId)
        {
            return new CourseService().querySeason(StuId);
        }
    }
}
