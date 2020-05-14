using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CourseService
    {
        /// <summary>
        ///查询课程性质（删除之前）
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public int queryCouresProperty(int CourseId)
        {
            string sql = "select courseproperty from CoursesMes where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@CourseId",CourseId)
          };
            object result = new Helper.SQLHelper().QuerySingleResult(sql, param, false);
            if ((result.ToString()).Equals("必修"))
                return 0;
            return 1;
        }


        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="Selected_courseid"></param>
        /// <returns></returns>
        public int deleteSelectedCourse(string Selected_courseid)
        {
            string sql = "delete from Courses_Stu where [Selected_courseid]=@Selected_courseid";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Selected_courseid",Selected_courseid)
            };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }


        /// <summary>
        /// 增加课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int addCourse(CourseMes course)
        {
            string sql = "insert into CoursesMes (CourseName,CollegeName,Xuefen,CourseNum,courseproperty,TeaId) Values (@CourseName,@CollegeName,@Xuefen,@CourseNum,@courseproperty,@TeaId)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@Xuefen",course.Xuefen),
                new SqlParameter("@courseproperty",course.courseproperty),
                new SqlParameter("@CourseNum",course.CourseNum),
                new SqlParameter("@CollegeName",course.CollegeName),
                new SqlParameter("@TeaId",course.TeaId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }


        //通过课程编号查看课程信息，
        public CourseMes queryCourseById(int courseId)
        {
            string sql = "select CourseName,Xuefen,CourseNum,courseproperty,CollegeName,TeaId from CoursesMes where CourseID=@CourseId";
            SqlParameter[] param = new SqlParameter[]
           {
                new SqlParameter("@CourseId",courseId),
           };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            CourseMes course = null;
            while (result.Read())
            {
                course = new CourseMes()
                {
                    CourseID = courseId,
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CourseNum = Convert.ToInt32(result["CourseNum"]),
                    courseproperty = result["courseproperty"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
                    TeaId=Convert.ToInt32(result["TeaId"])
                };
            }
            return course;
        }

        //通过审核
        public int checkCourseY(int courseId)
        {
            string sql = "update CoursesMes set SStatus='Y' where CourseID=@CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",courseId),
            };
            int result1= new Helper.SQLHelper().update(sql, param, false);
            return result1;
            }

        //向CourseMana中插入数据
        public int addCoursetoMana(CourseMes course,CourseMana courseExt)
        {
            string sql = "insert into CourseMana (CourseId,TeaId,Season,Time,CourseAdd)" +
                "values (@CourseId,@TeaId,@Season,@Time,@CourseAdd)";
            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@CourseId",course.CourseID),
                 new SqlParameter("@TeaId",course.TeaId),
                 new SqlParameter("@Season",courseExt.Season),
                 new SqlParameter("@Time",courseExt.Time),
                 new SqlParameter("@CourseAdd",courseExt.CourseAdd)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        /// <summary>
        /// 不通过审核
        /// </summary>
        /// <param name="courseId">待审核的课程id</param>
        /// <returns>1成功</returns>
        public int checkCourseN(int courseId)
        {
            string sql = "update CourseMes set SStatus='N' where CourseID=@CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",courseId),
            };
            int result1 = new Helper.SQLHelper().update(sql, param, false);
            return 0;
        }

        /// <summary>
        /// 查看所有待审批的课程
        /// </summary>
        /// <returns></returns>
        public List<CourseMes> showUncheck()
        {
            string sql = "select CourseId,CourseName,Xuefen,CourseNum,courseproperty,collegeName,SStatus from CoursesMes where SStatus='W'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            List<CourseMes> courselist = new List<CourseMes>();
            while (result.Read())
            {
                courselist.Add(new CourseMes()
                {
                    CourseID = Convert.ToInt32(result["CourseID"]),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CourseNum = Convert.ToInt32(result["CourseNum"]),
                    courseproperty = result["courseproperty"].ToString(),
                    CollegeName = result["collegeName"].ToString(),
                    SStatus = result["SStatus"].ToString()
                });
            }
            return courselist;
        }

        /// <summary>
        /// 查询所有可选课程
        /// </summary>
        /// <returns></returns>
        public List<CourseMana> queryAllCourse()
        {
            string sql = "select CourseId,CourseName,TeaName,Xuefen,courseproperty,Season,CollegeName from V_xuanke where SStatus='Y'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            List<CourseMana> courselist = new List<CourseMana>();
            while (result.Read())
            {
                courselist.Add(new CourseMana()
                {
                    CourseID = Convert.ToInt32(result["CourseID"]),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    TeaName = result["TeaName"].ToString(),
                    courseproperty = result["courseproperty"].ToString(),
                    Season=result["Season"].ToString(),
                    CollegeName = result["CollegeName"].ToString ()
                });
            }
            return courselist;
        }

        /// <summary>
        /// 按学号查询课程
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<CourseMana> queryCourseByStuId(int StuId)
        {
            string sql = "select Selected_courseid,CourseName,TeaName,Xuefen,courseproperty,Season,CollegeName,CourseAdd from course1 where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,param, false);
            List<CourseMana> courselist = new List<CourseMana>();
            while (result.Read())
            {
                courselist.Add(new CourseMana()
                {
                    Selected_courseid = result["Selected_courseid"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    TeaName = result["TeaName"].ToString(),
                    courseproperty = result["courseproperty"].ToString(),
                    Season = result["Season"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
                    CourseAdd=result["CourseAdd"].ToString()
                });
            }
            return courselist;
        }


        /// <summary>
        /// 查看通过审核的课程
        /// </summary>
        /// <returns></returns>
        public List<CourseMes> showChecked()
        {
            string sql = "select CourseId,CourseName,Xuefen,CourseNum,courseproperty,collegeName,SStatus from CoursesMes where SStatus='Y'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            List<CourseMes> courselist = new List<CourseMes>();
            while (result.Read())
            {
                courselist.Add(new CourseMes()
                {
                    CourseID = Convert.ToInt32(result["CourseID"]),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CourseNum = Convert.ToInt32(result["CourseNum"]),
                    courseproperty = result["courseproperty"].ToString(),
                    CollegeName = result["collegeName"].ToString(),
                    SStatus=result["SStatus"].ToString()
                });
            }
            return courselist;
        }
         
    }
}
