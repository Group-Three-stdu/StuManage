using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class KqService
    {
        //查询某一课程的考情记录
        public List<KQ> queryAllKq(int CourseId)
        {
            string sql = "select Row_Number() over(order by KQId) as '序号',KQId,CourseId,KqTime,EndTime,StuNum from KQ where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@CourseId",CourseId)
            };
            List<KQ> kqList = new List<KQ>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                kqList.Add(new KQ()
                {
                    KQXh=Convert.ToInt32(result["序号"]),
                    KQId = Convert.ToInt32(result["KQId"]),
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    KqTime = Convert.ToDateTime(result["KqTime"]),
                    EndTime = Convert.ToDateTime(result["EndTime"]),
                    StuNum = Convert.ToInt32(result["StuNum"])
                });
            }
            return kqList;
        }

        //发布考勤
        public int publishAttendance(KQ kq)
        {
            string sql = "insert into KQ (CourseId,KQTime,EndTime) values (@CourseId,@KQTime,@EndTime)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",kq.CourseId),
                new SqlParameter("@KQTime",kq.KqTime),
                new SqlParameter("@EndTime",kq.EndTime)
            };
            return new Helper.SQLHelper().update(sql,param,false);
        }

        //判断是否已经签到过，返回0表示未签到
        public int IsAttend(int StuId,int KQId)
        {
            string sql = "select count(*) from qiandao where StuId = @StuId and KQId = @KQId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@KQId",KQId),
            };
            object result = new Helper.SQLHelper().QuerySingleResult(sql, param, false);
            return Convert.ToInt32(result);
        }


        //完成签到
        public int AddKqRecord(int StuId,int KQId, DateTime time)
        {
            string sql = "insert into qiandao (StuId,KQId,time) values (@StuId,@KQId,@time)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@KQId",KQId),
                new SqlParameter("@time",time)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //增加签到人数
        public int UpdateStuNum(int KqId)
        {
            string sql = " update KQ set StuNum = StuNum+1 where KQId = @KqId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@KqId",KqId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }
    }
}
