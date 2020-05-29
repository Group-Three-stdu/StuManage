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
        public int deleteSelectedCourse(int CourseId,int StuId)
        {
            string sql = "delete from Courses_Stu where CourseId=@CourseId and StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@StuId",StuId)
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

        //通过课程编号查看选课信息
        public CourseMana selectCourseById(int courseId)
        {
            string sql = "select CourseId,TeaId,Season,Time,CourseAdd from CourseMana where CourseID=@CourseId";
            SqlParameter[] param = new SqlParameter[]
           {
                new SqlParameter("@CourseId",courseId),
           };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            CourseMana course = null;
            while (result.Read())
            {
                course = new CourseMana()
                {
                    CourseID = courseId,
                    Time=result["Time"].ToString(),
                    Season = result["Season"].ToString(),
                    CourseAdd = result["CourseAdd"].ToString(),
                    TeaId = Convert.ToInt32(result["TeaId"])
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
            string sql = "select CourseId,CourseName,Xuefen,CourseNum,courseproperty,collegeName from CoursesMes where SStatus='W'";
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
                    CollegeName = result["collegeName"].ToString()
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
                    CollegeName = result["CollegeName"].ToString (),
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
            string sql = "select CourseId,CourseName,Xuefen,CourseNum,courseproperty,collegeName from CoursesMes where SStatus='Y'";
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
                    CollegeName = result["collegeName"].ToString()
                });
            }
            return courselist;
        }

        /// <summary>
        /// 学生选择课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int chooseCourse(Course_Stu course)
        {
            string sql = "insert into Courses_Stu (StuId,CourseId,CourseName,Season,Time,TeaId) Values (@StuId,@CourseId,@CourseName,@Season,@Time,@TeaId)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",course.StuId),
                new SqlParameter("@CourseId",course.CourseId),
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@Season",course.Season),
                new SqlParameter("@Time",course.Time),
                new SqlParameter("@TeaId",course.TeaId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查看已选课程
        public List<Course_Stu> showSelectedCourse(int StuId)
        {
            string sql = "select CourseId,CourseName,Season,Time,TeaId from Courses_Stu where StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,param, false);
            List<Course_Stu> courselist = new List<Course_Stu>();
            while (result.Read())
            {
                courselist.Add(new Course_Stu()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    CourseName = result["CourseName"].ToString(),
                    Season = result["Season"].ToString(),
                    Time = result["Time"].ToString(),
                    TeaId = Convert.ToInt32(result["TeaId"])
                });
            }
            return courselist;
        
    }

        //按姓名模糊查找
        public List<CourseMana> queryCourseByName(string Name)
        {
            string sql = "select CourseId,CourseName,TeaName,Xuefen,courseproperty,Season,CollegeName from V_xuanke where CourseName LIKE '%"+Name+"%'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,false);
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
                    Season = result["Season"].ToString(),
                    CollegeName = result["CollegeName"].ToString()
                });
            }
            return courselist;
        }

        //查看已选课程（全）
        public List<CourseMana> queryCourseInfoByStuId (int StuId)
        {
            string sql = "SELECT StuId,TeaName, CourseID, Season, courseproperty, Xuefen, CourseName, CollegeName,CourseAdd FROM V_course2 where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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
                    Season = result["Season"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
                    CourseAdd = result["CourseAdd"].ToString()
                });
            }
            return courselist;
        }

        //查询教师的所有课程
        public List<CourseMes> queryCourseInfoByTeaId(int TeaId)
        {
            string sql = "SELECT CourseID, courseproperty, Xuefen, CourseName, CollegeName,Time FROM V_TeaCourse where TeaId=@TeaId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@TeaId",TeaId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            List<CourseMes> courselist = new List<CourseMes>();
            while (result.Read())
            {
                courselist.Add(new CourseMes()
                {
                    CourseID = Convert.ToInt32(result["CourseID"]),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    courseproperty = result["courseproperty"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
                    Time = result["Time"].ToString()
                });
            }
            return courselist;
        }

        //查询该课程的所有班级
        public List<Model.Class> queryClassByCourseId(int CourseId)
        {
            string sql = "select distinct ClassId from V_CourseTea where CourseId=@CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            List<Model.Class> classList = new List<Model.Class>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                classList.Add(new Model.Class()
                {
                    ClassId = result["ClassId"].ToString()
                });
            }
            return classList;
        }

        //增加课程成绩占比
        public int AddRatio(int CourseId,float MatchRatio, float ClassRatio)
        {
            string sql = "update CourseMana set MatchRatio = @MatchRatio ,ClassRatio = @ClassRatio where CourseId=@CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MatchRatio",MatchRatio),
                new SqlParameter("@ClassRatio",ClassRatio),
                new SqlParameter("@CourseId",CourseId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查询某一课程学生的人数
        public int QueryStuNum(int courseId)
        {
            string sql = "select count(DISTINCT StuId) as stuNum from Courses_Stu where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@courseId",courseId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql,param,false));
        }
        
        //查询所有学期
        public List<CourseMana> querySeason (int StuId)
        {
            string sql = "select distinct Season from Courses_Stu where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            List<CourseMana> SeasonList = new List<CourseMana>();
            while (res.Read())
            {
                SeasonList.Add(new CourseMana()
                {
                    Season = res["Season"].ToString()
                });
            }
            return SeasonList;
        }

        //查看辅导员的班级
        public List<Class> queryFDYClass(int FDYID)
        {
            string sql = "select classId,Major,College,fudaoyuan,MajorName,CollegeName from V_Class where fudaoyuan = @FDYID";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@FDYID",FDYID)
            };
            List<Class> clalist = new List<Class>();
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (res.Read())
            {
                clalist.Add(new Class()
                {
                    ClassId = res["classId"].ToString(),
                    majorId = res["Major"].ToString(),
                    collegId = res["College"].ToString(),
                    fudaoyuan = Convert.ToInt32(res["fudaoyuan"]),
                    MajorName = res["MajorName"].ToString(),
                    CollegeName = res["CollegeName"].ToString()
                });
            }
            return clalist;
        }

        //查看某一班级的所有课程
        public List<CourseMana> queryCourseInfoByClassId(string ClassId)
        {
            string sql = "SELECT CourseID, CourseName,Season,TeaName FROM V_fudaoyuancourse where ClassID=@ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",ClassId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            List<CourseMana> courselist = new List<CourseMana>();
            while (result.Read())
            {
                courselist.Add(new CourseMana()
                {
                    CourseID = Convert.ToInt32(result["CourseID"]),
                    CourseName = result["CourseName"].ToString(),
                    Season =result["Season"].ToString(),
                    TeaName = result["TeaName"].ToString()
                });
            }
            return courselist;
        }

        //查询课程是否已经选择过
        public int IsExistCourse(int CourseId,int StuId)
        {
            string sql = "select count(*) from Courses_Stu where CourseId =@CourseId and StuId =@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@StuId",StuId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }

        //查询已选学分
        public float CalPoint(int StuId)
        {
            string sql = "select Sum(Xuefen) from V_Xuefen where StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            string point = new Helper.SQLHelper().QuerySingleResult(sql, param, false).ToString();
            if (point == "")
                return 0;
            else
                return float.Parse(point);
        }

        //查询课程学分
        public float CalCoursePoint(int CourseId)
        {
            string sql = "select Xuefen from CoursesMes where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            return float.Parse(new Helper.SQLHelper().QuerySingleResult(sql, param, false).ToString());
        }
    }
}
