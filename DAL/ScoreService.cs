using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ScoreService
    {

        //增加学生成绩
        public int addStuScore(Score sc)
        {
            string sql = "insert into Score (StuId,CourseId,ClassScore,MatchScore,FinalScore) values (@StuId,@CourseId,@ClassScore,@MatchScore,@FinalScore)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",sc.StuId),
                new SqlParameter("@CourseId",sc.CourseId),
                new SqlParameter("@ClassScore",sc.ClassScore),
                new SqlParameter("@MatchScore",sc.MatchScore),
                new SqlParameter("@FinalScore",sc.FinalScore)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }

        //查询某课程的成绩记录条数
        public int queryCouseScoreNum(int CourseId)
        {
            string sql = "select count(1) from Score where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }
    }
}
