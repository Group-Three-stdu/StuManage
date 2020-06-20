using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HomeworkService
    {
        /// <summary>
        /// 查看某门课程所有作业
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Homework> queryHKByStuId(int CourseId)
        {
            string sql = "select HwId,StartTime,EndTime,HwContent,CourseId,HwHead from Homework where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@CourseId",CourseId)
            };
            List<Homework> hklist = new List<Homework>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                hklist.Add(new Homework()
                {
                    HwId = Convert.ToInt32(result["HwId"]),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    HwContent = result["HwContent"].ToString(),
                    CourseId = CourseId,
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }

        /// <summary>
        /// 查看未完成的作业
        /// </summary>
        /// <param name="CourseId"></param>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<Homework> queryUnfinishedHw(int CourseId,int StuId)
        {
            string sql = "select HwId,StartTime,EndTime,HwContent,CourseId,HwHead from Homework where CourseId = @CourseId and HwId  not in (Select distinct HwId from V_Hw where StuId = @StuId )";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@StuId",StuId)
            };
            List<Homework> hklist = new List<Homework>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                hklist.Add(new Homework()
                {
                    HwId = Convert.ToInt32(result["HwId"]),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    HwContent = result["HwContent"].ToString(),
                    CourseId = CourseId,
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }

        /// <summary>
        /// 查看作业细节
        /// </summary>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public Homework queryHkByHkId(int HwId)
        {
            string sql = "select HwId,StartTime,EndTime,HwContent,CourseId,HwHead from Homework where HwId = @HwId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@HwId",HwId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            Homework hw = null;
            while (result.Read())
            {
                hw = new Homework()
                {
                    HwId = HwId,
                    HwContent = result["HwContent"].ToString(),
                    HwHead = result["HwHead"].ToString(),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    CourseId = Convert.ToInt32(result["CourseId"])
                };
            }
            return hw;
        }

        /// <summary>
        /// 学生提交作业
        /// </summary>
        /// <param name="ans"></param>
        /// <returns></returns>
        public int SubmitHw(Answer_Stu ans)
        {
            string sql = "insert into Answer_Stu (StuId  ,HwId,Answer,Time ) Values(@StuId  ,@HwId,@Answer,@Time )";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@StuId",ans.StuId),
                new SqlParameter ("@HwId",ans.HwId),
                new SqlParameter ("@Answer",ans.Answer),
                new SqlParameter ("@Time",ans.Time)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        /// <summary>
        /// 更新作业表中的完成人数
        /// </summary>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public int alterFinishNum(int HwId)
        {
            string sql = "update Homework set FinishNum = FinishNum+1 where HwId = @HwId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@HwId",HwId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        /// <summary>
        /// 教师查看某门课的作业情况
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Homework> queryAllHKByTea(int CourseId)
        {
            string sql = "select HwId,StartTime,EndTime,HwHead,FinishNum from Homework where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@CourseId",CourseId)
            };
            List<Homework> hklist = new List<Homework>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                hklist.Add(new Homework()
                {
                    HwId = Convert.ToInt32(result["HwId"]),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    FinishNum = Convert.ToInt32(result["FinishNum"]),
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }

        /// <summary>
        /// 教师发布作业
        /// </summary>
        /// <param name="hw"></param>
        /// <returns></returns>
        public int fabuHw(Homework hw)
        {
            string sql = "insert into homework (StartTime,EndTime,HwContent,CourseId,HwHead) values (@StartTime,@EndTime,@HwContent,@CourseId,@HwHead)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StartTime",hw.StartTime),
                new SqlParameter("@EndTime",hw.EndTime),
                new SqlParameter("@HwContent",hw.HwContent),
                new SqlParameter("@CourseId",hw.CourseId),
                new SqlParameter("@HwHead",hw.HwHead),
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        /// <summary>
        /// 查询未提交作业的学生学号
        /// </summary>
        /// <param name="HwId"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<Students> queryUnsubmitStuId(int HwId, int CourseId)
        {
            string sql = "select distinct StuId from Courses_Stu  where StuId not in (select distinct StuId from Answer_Stu where HwId=@HwId ) and CourseId=@CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@HwId",HwId),
                new SqlParameter("@CourseId",CourseId)
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            List<Students> StuList = new List<Students>();
            while (result.Read())
            {
                StuList.Add(new Students()
                {
                    StuId = Convert.ToInt32(result["StuId"])
                });
            }
            return StuList;
        }

        /// <summary>
        /// 查询已提交作业的学生信息
        /// </summary>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public List<Answer_Stu> querySubmitedStu(int HwId)
        {
            string sql = "select StuId,StuName,Answer,Grade,Resist,Time,ClassId,HwState,HwId from V_SubmitHw  where  HwId=@HwId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@HwId",HwId),
            };
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            List<Answer_Stu> StuList = new List<Answer_Stu>();
            while (result.Read())
            {
                StuList.Add(new Answer_Stu()
                {
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    Answer = result["Answer"].ToString(),
                    Grade = result["Grade"].ToString(),
                    Resist = result["Resist"].ToString(),
                    Time = Convert.ToDateTime(result["Time"]),
                    ClassId = result["ClassId"].ToString(),
                    HwState = result["HwState"].ToString(),
                    HwId = Convert.ToInt32(result["HwId"])
                });
            }
            return StuList;
        }

        /// <summary>
        /// 查看学生作业
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="HwId"></param>
        /// <returns></returns>
        public Answer_Stu queryStuAnsByStuId(int StuId,int HwId)
        {
            string sql = "select StuId,HwId,Answer,Grade,Resist,Time,HwState from Answer_Stu where StuId=@StuId and HwId = @HwId ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@HwId",HwId)
            };
            Answer_Stu ans = new Answer_Stu();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                ans.StuId = Convert.ToInt32(result["StuId"]);
                ans.HwId = Convert.ToInt32(result["HwId"]);
                ans.Answer = result["Answer"].ToString();
                ans.Grade = result["Grade"].ToString();
                ans.Resist = result["Resist"].ToString();
                ans.Time = Convert.ToDateTime(result["Time"]);
                ans.HwState = result["HwState"].ToString();
            }
            return ans;
        }

        //插入教师的评语
        public int TeaCheckAns(string Grade,string Resist,int StuId,int HwId)
        {
            string sql = "update Answer_Stu set Grade=@Grade, Resist=@Resist where StuId=@StuId and HwId = @HwId ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Grade",Grade),
                new SqlParameter("@Resist",Resist),
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@HwId",HwId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //将作业状态改成已批阅
        public int TeaChangeAnsSta(int StuId, int HwId)
        {
            string sql = "update Answer_Stu set HwState='F'  where StuId=@StuId and HwId = @HwId ";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@HwId",HwId)
          };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查询学生是否已经提交过作业
        public int queryHasSubmited(int StuId,int HwId)
        {
            string sql = "select count(*) from Answer_Stu  where StuId=@StuId and HwId = @HwId ";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@HwId",HwId)
          };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }

        //查询学生的作业情况
        public int queryStuHwNum(int StuId,int CourseId)
        {
            string sql = "select count(*) as HwNum from V_Hw where StuId = @StuId and CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@CourseId",CourseId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }

        // 查询已完成但未审批的作业
        public List<Homework> queryfinishedHw(int CourseId, int StuId)
        {
            string sql = "select Homework.HwId,StartTime,EndTime,HwContent,CourseId,HwHead,Answer,Time from Homework join Answer_Stu on Homework.HwId = Answer_Stu.HwId where HwState = 'W' and CourseId = @CourseId and StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@StuId",StuId)
            };
            List<Homework> hklist = new List<Homework>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                hklist.Add(new Homework()
                {
                    HwId = Convert.ToInt32(result["HwId"]),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    HwContent = result["HwContent"].ToString(),
                    CourseId = CourseId,
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }

        // 查询已未审批的作业
        public List<Homework> querycheckedHw(int CourseId, int StuId)
        {
            string sql = "select Homework.HwId,StartTime,EndTime,HwContent,CourseId,HwHead,Answer,Time from Homework join Answer_Stu on Homework.HwId = Answer_Stu.HwId where HwState = 'F' and CourseId = @CourseId and StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@StuId",StuId)
            };
            List<Homework> hklist = new List<Homework>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                hklist.Add(new Homework()
                {
                    HwId = Convert.ToInt32(result["HwId"]),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    HwContent = result["HwContent"].ToString(),
                    CourseId = CourseId,
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }
    }
}
