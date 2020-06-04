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
            string sql = "select  Row_Number() over(order by ID) as xh ,Id ,GGHead,GGContent,TeaId,Time,TeaName from V_LookJXGG where CourseId = @CourseId";
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
                    xh=Convert.ToInt32(result["xh"]),
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

        //查看公告详细信息
        public XTGG queryDetail(int GGId)
        {
            string sql = "select Id ,GGHead,GGContent,GGauthor,GGdateTime from XTGG where Id = @GGId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@GGId",GGId)
            };
            XTGG gg = null;
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (res.Read())
            {
                gg = new XTGG()
                {
                    GGHead = res["GGHead"].ToString(),
                    GGcontent = res["GGContent"].ToString(),
                    GGauthor = res["GGauthor"].ToString(),
                    GGdateTime = Convert.ToDateTime(res["GGdateTime"])
                };
            }
            return gg;
        }

        //删除系统公告
        public int DelXTGG(int GGId)
        {
            string sql = "delete from XTGG where ID = @GGId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@GGId",GGId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查看系统公告
        public List<XTGG> LookXTGG()
        {
            string sql = "select  Row_Number() over(order by ID) as xh ,Id ,GGHead,GGContent,GGauthor,GGdateTime from XTGG";
            List<XTGG> gglist = new List<XTGG>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql , false);
            while (result.Read())
            {
                gglist.Add(new XTGG()
                {
                    xh = Convert.ToInt32(result["xh"]),
                    GGId = Convert.ToInt32(result["Id"]),
                    GGHead = result["GGHead"].ToString(),
                    GGcontent = result["GGContent"].ToString(),
                    GGauthor = result["GGauthor"].ToString(),
                    GGdateTime = Convert.ToDateTime(result["GGdateTime"])
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

        //删除公告
        public int DelGG(int GGId)
        {
            string sql = "delete from JXGG where ID = @GGId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@GGId",GGId)
            };
            return new Helper.SQLHelper().update(sql, param,false);
        }

        //发布系统公告
        public int fabuXTGG(XTGG gg)
        {
            string sql = "insert into XTGG (GGHead,GGcontent,GGauthor,GGdateTime) values (@GGHead,@GGcontent,@GGauthor,@GGdateTime) ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@GGHead",gg.GGHead),
                new SqlParameter("@GGContent",gg.GGcontent),
                new SqlParameter("@GGauthor",gg.GGauthor),
                new SqlParameter("@GGdateTime",gg.GGdateTime)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }
    }
}
