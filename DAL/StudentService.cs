﻿using System;
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
                stu.College = result["College"].ToString();
                stu.Major = result["Major"].ToString();
                stu.MajorName = result["MajorName"].ToString();
                stu.CollegeName = result["CollegeName"].ToString();
                stu.StuState = result["StuState"].ToString();
                stu.Punish = result["Punish"].ToString();
                stu.PoliticalStatus = result["PoliticalStatus"].ToString();
            }
            return stu;
        }

        /// <summary>
        /// 辅导员通过学号查询
        /// </summary>
        /// <param name="stuId"></param>
        /// <param name="classId"></param>
        /// <returns></returns>
        public List<Students> FDYqueryStudentByStuId(int StuId, string classId)
        {
            string sql = "select Students.StuId,StuName,ClassId,StuPhoneNum from Students where ClassId=@ClassId  and StuId=@StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",classId),
                 new SqlParameter("@StuId",StuId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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
        /// 辅导员通过姓名模糊查询
        /// </summary>
        /// <param name="stuName"></param>
        /// <param name="classId"></param>
        /// <returns></returns>
        public List<Students> FDYqueryStudentByStuName(string stuName, string classId)
        {
            string sql = "select Students.StuId,StuName,ClassId,StuPhoneNum from Students where ClassId=@ClassId  and StuName Like  '%" + stuName + "%'";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",classId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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
        /// 根据班级，课程编号查询学生
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public List<Students> TeaqueryStudentByClassId(int CourseId ,string ClassId)
        {
            string sql = "select StuId,StuName,ClassId,StuPhoneNum from V_CourseTea where CourseId = @CourseId and ClassId = @ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@ClassId",ClassId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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
                sql += " and StuId LIKE '%" + StuId + "%'";
            if (StuName != "")
                sql += " and StuName  LIKE '%" + StuName + "%'";
            if (ClassId != "")
                sql += " and Students.ClassId='" + ClassId + "'";
            if(College!="")
                sql += " and Students.College='" + College + "'";
            if(Major!="")
                sql += " and Students.Major='" + Major + "'";
            List<Students> stulist = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,  false);
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
                    MajorName = result["MajorName"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
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
                    MajorName = result["MajorName"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
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
                " join ZY on Students.Major=ZY.Major where Students.College=@College";
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
                    MajorName = result["MajorName"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
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
                    MajorName = result["MajorName"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
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
                    MajorName = result["MajorName"].ToString(),
                    CollegeName = result["CollegeName"].ToString(),
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

        //查询学生未完成课程数
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
        public List<Students> TeaqueryStudentByStuName(string Name,int CourseId)
        {
            string sql = "select Students.StuId,StuName,ClassId,StuPhoneNum from Students join Courses_Stu on Students.StuId=Courses_Stu.StuId where CourseId=@CourseId  and StuName Like  '%" + Name + "%'";
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

        //教师通过学号查找学生
        public List<Students> TeaqueryStudentByStuId(int StuId)
        {
            string sql = "select StuId,StuName,ClassId,StuPhoneNum from Students where StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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

        //查看某个班级的所有学生
        public List<Students> queryStudentByClassId(string ClassId)
        {
            string sql = "select StuId,StuName,ClassId,StuPhoneNum from Students where ClassId = @ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",ClassId)
            };
            List<Students> stuList = new List<Students>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
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

        //查询某个学生是否存在
        public int IsExist(int StuId)
        {
            string sql = "select count(*) from Students where StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }

        //增加学生
        public int AddStu(Students stu)
        {
            string sql = "insert into Students (StuId,StuName, StuSex, StuBirth, StuNoId, StuPhoneNum, StuAdd, ClassId, StuHonor, Students.Major, Students.College,StuState,Punish,PoliticalStatus) " +
                " Values(@StuId,@StuName, @StuSex, @StuBirth, @StuNoId, @StuPhoneNum, @StuAdd, @ClassId, @StuHonor, @Major, @College,@StuState,@Punish,@PoliticalStatus) ";
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
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查询学生人数
        public int queryStuNumByClassId(string ClassId)
        {
            string sql = "select count(*) from Students where ClassId = @ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassId",ClassId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }
    }
}
