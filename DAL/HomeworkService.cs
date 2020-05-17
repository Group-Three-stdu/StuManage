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
                    HwId = result["HwId"].ToString(),
                    StartTime = Convert.ToDateTime(result["StartTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    HwContent = result["HwContent"].ToString(),
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    HwHead = result["HwHead"].ToString()
                });
            }
            return hklist;
        }
    }
}
