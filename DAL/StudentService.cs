using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentService
    {
        /// <summary>
        /// 通过学号查询学生信息
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public Students queryStuById(int StuId)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
                " from Students join XY on Students.College=XY.College " +
                 " join ZY on Students.Major=ZY.Major where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            Students stu = new Students();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                stu.StuId = Convert.ToInt32(result["StuId"]);
                stu.StuName = result["StuName"].ToString();
                stu.StuSex = result["StuSex"].ToString();
                stu.StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString("yyyy-MM-dd");
                stu.StuNoId = result["StuNoId"].ToString();
                stu.StuPhoneNum = result["StuPhoneNum"].ToString();
                stu.StuAdd = result["StuAdd"].ToString();
                stu.ClassId = result["ClassId"].ToString();
                stu.StuHonor = result["StuHonor"].ToString();
                stu.Major = result["MajorName"].ToString();
                stu.College = result["CollegeName"].ToString();
                stu.StuState = result["StuState"].ToString();
                stu.Punish = result["Punish"].ToString();
                stu.PoliticalStatus = result["PoliticalStatus"].ToString();
            }
            return stu;
        }

        /// <summary>
        /// 查询某一课程的所有学生
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public List<Students> queryStudentByCourseId(int CourseId)
        {
            string sql = "select StuId,StuName,ClassId,StuPhoneNum from V_CourseTea where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param,false);
            while (result.Read())
            {
                stuList.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString()
                });
            }
            return stuList;
        }

        /// <summary>
        /// 综合查询
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="StuName"></param>
        /// <param name="ClassId"></param>
        /// <param name="College"></param>
        /// <param name="Major"></param>
        /// <returns></returns>
        public List<Students> queryStu(int StuId,string StuName,string ClassId,string College,string Major)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
               " from Students join XY on Students.College=XY.College " +
                " join ZY on Students.Major=ZY.Major where 1=1";
            if (StuId != 0)
                sql += " and StuId=" +StuId;
            if (StuName != "")
                sql += " and StuName='" + StuName + "'";
            if (ClassId != "")
                sql += " and ClassId='" + ClassId + "'";
            if(College!="")
                sql += " and College='" + College + "'";
            if(Major!="")
                sql += " and Major='" + Major + "'";
            List<Students> stulist = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,  false);
            while (result.Read())
            {
                stulist.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    StuSex = result["StuSex"].ToString(),
                    StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString ("yyyy-MM-dd"),
                    StuNoId = result["StuNoId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString(),
                    StuAdd = result["StuAdd"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuHonor = result["StuHonor"].ToString(),
                    Major = result["Major"].ToString(),
                    College = result["College"].ToString(),
                    StuState = result["StuState"].ToString(),
                    Punish = result["Punish"].ToString(),
                    PoliticalStatus = result["PoliticalStatus"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 通过班级编号查询学生信息
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public List<Students> queryStuByClassId(string ClassId)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
               " from Students join XY on Students.College=XY.College " +
                " join ZY on Students.Major=ZY.Major where ClassId=@ClassId";
            List<Students> stulist = new List<Students>();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",ClassId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                stulist.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    StuSex = result["StuSex"].ToString(),
                    StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString ("yyyy-MM-dd"),
                    StuNoId = result["StuNoId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString(),
                    StuAdd = result["StuAdd"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuHonor = result["StuHonor"].ToString(),
                    Major = result["Major"].ToString(),
                    College = result["College"].ToString(),
                    StuState = result["StuState"].ToString(),
                    Punish = result["Punish"].ToString(),
                    PoliticalStatus = result["PoliticalStatus"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 通过学院名称查询学生信息
        /// </summary>
        /// <param name="College"></param>
        /// <returns></returns>
        public List<Students> queryStuByCollege(string College)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
               " from Students join XY on Students.College=XY.College " +
                " join ZY on Students.Major=ZY.Major where CollegeName=@College";
            List<Students> stulist = new List<Students>();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@College",College)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                stulist.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    StuSex = result["StuSex"].ToString(),
                    StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString ("yyyy-MM-dd"),
                    StuNoId = result["StuNoId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString(),
                    StuAdd = result["StuAdd"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuHonor = result["StuHonor"].ToString(),
                    Major = result["Major"].ToString(),
                    College = result["College"].ToString(),
                    StuState = result["StuState"].ToString(),
                    Punish = result["Punish"].ToString(),
                    PoliticalStatus = result["PoliticalStatus"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 通过专业名称查询学生信息
        /// </summary>
        /// <param name="Major"></param>
        /// <returns></returns>
        public List<Students> queryStuByMajor(string Major)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
               " from Students join XY on Students.College=XY.College " +
                " join ZY on Students.Major=ZY.Major where MajorName=@Major";
            List<Students> stulist = new List<Students>();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Major",Major)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                stulist.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    StuSex = result["StuSex"].ToString(),
                    StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString("yyyy-MM-dd"),
                    StuNoId = result["StuNoId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString(),
                    StuAdd = result["StuAdd"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuHonor = result["StuHonor"].ToString(),
                    Major = result["Major"].ToString(),
                    College = result["College"].ToString(),
                    StuState = result["StuState"].ToString(),
                    Punish = result["Punish"].ToString(),
                    PoliticalStatus = result["PoliticalStatus"].ToString()
                });
            }
            return stulist;
        }


        ///// <summary>
        /// 通过姓名查询学生信息
        /// </summary>
        /// <param name="Major"></param>
        /// <returns></returns>
        public List<Students> queryStuByName(string StuName)
        {
            string sql = "select StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus, CollegeName,MajorName" +
               " from Students join XY on Students.College=XY.College " +
                " join ZY on Students.Major=ZY.Major where StuName=@StuName";
            List<Students> stulist = new List<Students>();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuName",StuName)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                stulist.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    StuSex = result["StuSex"].ToString(),
                    StuBirth = Convert.ToDateTime(result["StuBirth"]).ToString("yyyy-MM-dd"),
                    StuNoId = result["StuNoId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString(),
                    StuAdd = result["StuAdd"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuHonor = result["StuHonor"].ToString(),
                    Major = result["Major"].ToString(),
                    College = result["College"].ToString(),
                    StuState = result["StuState"].ToString(),
                    Punish = result["Punish"].ToString(),
                    PoliticalStatus = result["PoliticalStatus"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 按学号删除
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public int DleteStudent(int StuId)
        {
            string sql = "delete from Students where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }

        /// <summary>
        /// 按学号修改
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public int UpdateStudent(Students stu)
        {
            string sql = "update Students set StuName=@StuName, StuSex=@StuSex, StuBirth=@StuBirth, StuNoId=@StuNoId, "+
                "StuPhoneNum=@StuPhoneNum, StuAdd=@StuAdd, ClassId=@ClassId, StuHonor=@StuHonor, Students.Major=@Major, "+
                "Students.College=@College,StuState=@StuState,Punish=@Punish,PoliticalStatus=@PoliticalStatus"+
                " where StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",stu.StuId),
                new SqlParameter("@StuName",stu.StuName),
                new SqlParameter("@StuSex",stu.StuSex),
                new SqlParameter("@StuBirth",stu.StuBirth),
                new SqlParameter("@StuNoId",stu.StuNoId),
                new SqlParameter("@StuPhoneNum",stu.StuPhoneNum),
                new SqlParameter("@StuAdd",stu.StuAdd),
                new SqlParameter("@ClassId",stu.ClassId),
                new SqlParameter("@StuHonor",stu.StuHonor),
                new SqlParameter("@Major",stu.Major),
                new SqlParameter("@College",stu.College),
                new SqlParameter("@StuState",stu.StuState),
                new SqlParameter("@Punish",stu.Punish),
                new SqlParameter("@PoliticalStatus",stu.PoliticalStatus),
            };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }

        /// <summary>
        /// 增加学生
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int AddStudent(Students stu)
        {
            string sql = "insert into Students (StuId,StuName, StuSex, StuBirth, StuNoId ,StuPhoneNum, StuAdd, ClassId, StuHonor, Major, " +
                "College,StuState,Punish,PoliticalStatus) values(@StuId,@StuId,StuName, @StuSex, @StuBirth, @StuNoId ,@StuPhoneNum, @StuAdd, @ClassId," +
                " @StuHonor, @Major, @College,@StuState,@Punish,@PoliticalStatus)";
            SqlParameter[] param = new SqlParameter[]
               {
                new SqlParameter("@StuId",stu.StuId),
                new SqlParameter("@StuName",stu.StuName),
                new SqlParameter("@StuSex",stu.StuSex),
                new SqlParameter("@StuBirth",stu.StuBirth),
                new SqlParameter("@StuNoId",stu.StuNoId),
                new SqlParameter("@StuPhoneNum",stu.StuPhoneNum),
                new SqlParameter("@StuAdd",stu.StuAdd),
                new SqlParameter("@ClassId",stu.ClassId),
                new SqlParameter("@StuHonor",stu.StuHonor),
                new SqlParameter("@Major",stu.Major),
                new SqlParameter("@College",stu.College),
                new SqlParameter("@StuState",stu.StuState),
                new SqlParameter("@Punish",stu.Punish),
                new SqlParameter("@PoliticalStatus",stu.PoliticalStatus),
               };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }

        public int queryCourseByStuId(int StuId)
        {
            string sql = "select count(*) from Courses_Stu where StuId=@StuId and Status='N' ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            int result = Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
            return result;
        }

        //教师按姓名模糊查询某门课程的学生
        public List<Students> TeaqueryStudentByStuName(string Name)
        {
            string sql = "select StuId,StuName,ClassId,StuPhoneNum from Students where StuName Like  '%" + Name + "%'";
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            while (result.Read())
            {
                stuList.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    ClassId = result["ClassId"].ToString(),
                    StuPhoneNum = result["StuPhoneNum"].ToString()
                });
            }
            return stuList;
        }
    }
}
