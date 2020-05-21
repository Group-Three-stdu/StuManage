using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GGService
    {
        //查看公告
        public List<JXGG> LookJXGG (int CourseId)
        {
            string sql = "select  Row_Number() over(order by ID) as id ,GGHead,GGContent,TeaId,Time,TeaName from V_LookJXGG where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId", CourseId)
            } ;
            List<JXGG> gglist = new List<JXGG>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                gglist.Add(new JXGG()
                {
                    Id = Convert.ToInt32(result["id"]),
                    GGHead = result["GGHead"].ToString(),
                    GGContent = result["GGContent"].ToString(),
                    TeaId = Convert.ToInt32(result["TeaId"]),
                    Time = Convert.ToDateTime(result["Time"]),
                    TeaName = result["TeaName"].ToString()
                });
            }
            return gglist;
        }

        //发布公告
        public int fabuGG(JXGG gg)
        {
            string sql = "insert into JXGG (GGHead,GGContent,TeaId,Time,CourseId) values (@GGHead,@GGContent,@TeaId,@Time,@CourseId) ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@GGHead",gg.GGHead),
                new SqlParameter("@GGContent",gg.GGContent),
                new SqlParameter("@TeaId",gg.TeaId),
                new SqlParameter("@Time",gg.Time),
                new SqlParameter("@CourseId",gg.CourseId),
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }
    }
}
