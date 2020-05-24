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

        //学生查看成绩
        public List<Score> queryScore(int StuId)
        {
            string sql = "SELECT   StuId, CourseId, ClassScore, MatchScore, FinalScore, SCID, CourseName, Xuefen, CourseNum, courseproperty, CollegeName, TeaId, TeaName from V_StuScore where StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            List<Score> sclist = new List<Score>();
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (res.Read())
            {
                sclist.Add(new Score()
                {
                    StuId = Convert.ToInt32(res["StuId"]),
                    CourseId = Convert.ToInt32(res["CourseId"]),
                    SCID = Convert.ToInt32(res["SCID"]),
                    CourseNum = Convert.ToInt32(res["CourseNum"]),
                    TeaId = Convert.ToInt32(res["TeaId"]),
                    ClassScore = float.Parse(res["ClassScore"].ToString()),
                    MatchScore = float.Parse(res["MatchScore"].ToString()),
                    FinalScore = float.Parse(res["FinalScore"].ToString()),
                    Xuefen = float.Parse(res["Xuefen"].ToString()),
                    CourseName = res["CourseName"].ToString(),
                    courseproperty = res["courseproperty"].ToString(),
                    CollegeName = res["CollegeName"].ToString(),
                    TeaName = res["TeaName"].ToString(),
                });
            }
            return sclist;
        }
    }
}
