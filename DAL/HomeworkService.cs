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
    }
}
