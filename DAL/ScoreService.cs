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

        //辅导员查看成绩
        public List<ScoreExt> queryScorebyFDY(int CourseId, string ClassId)
        {
            string sql = "SELECT   CourseId,StuId, StuName, College, ClassScore, MatchScore, FinalScore, ClassId,CourseName, Xuefen, CollegeName from V_tea_score where CourseId = @CourseId and ClassId = @ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@ClassId",ClassId)
            };
            List<ScoreExt> sclist = new List<ScoreExt>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                sclist.Add(new ScoreExt()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    College = result["College"].ToString(),
                    MatchScore = float.Parse(result["MatchScore"].ToString()),
                    ClassScore = float.Parse(result["ClassScore"].ToString()),
                    FinalScore = float.Parse(result["FinalScore"].ToString()),
                    ClassId = result["ClassId"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CollegeName = result["CollegeName"].ToString(),
                });
            }
            return sclist;
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
            string sql = "SELECT   StuId, CourseId, ClassScore, MatchScore, FinalScore, SCID, CourseName, Xuefen, CourseNum, courseproperty, CollegeName, TeaId, TeaName,Season from V_StuScore where StuId = @StuId";
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
                    Season = res["Season"].ToString()
                });
            }
            return sclist;
        }
        //根据学期查询分数
        public List<Score> queryScoreBySea(int StuId, string Season)
        {
            string sql = "SELECT   StuId, CourseId, ClassScore, MatchScore, FinalScore, SCID, CourseName, Xuefen, CourseNum, courseproperty, CollegeName, TeaId, TeaName,Season from V_StuScore where StuId = @StuId and Season = @Season";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@Season",Season)
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
                    Season = res["Season"].ToString()
                });
            }
            return sclist;
        }

        //根据课程名模糊查询分数
        public List<Score> queryScoreBySeaByName(int StuId, string name)
        {
            string sql = "SELECT   StuId, CourseId, ClassScore, MatchScore, FinalScore, SCID, CourseName, Xuefen, CourseNum, courseproperty, CollegeName, TeaId, TeaName,Season from V_StuScore where StuId = @StuId and CourseName Like  '%" + name + "%'";
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
                    Season = res["Season"].ToString()
                });
            }
            return sclist;
        }

        //根据课程名和学期模糊查询分数
        public List<Score> queryScoreBySeaByName(int StuId, string Season,string name)
        {
            string sql = "SELECT   StuId, CourseId, ClassScore, MatchScore, FinalScore, SCID, CourseName, Xuefen, CourseNum, courseproperty, CollegeName, TeaId, TeaName,Season from V_StuScore where StuId = @StuId and Season = @Season and CourseName Like  '%" + name + "%'";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId),
                new SqlParameter("@Season",Season)
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
                    Season = res["Season"].ToString()
                });
            }
            return sclist;
        }

        //教师查看成绩
        public List<ScoreExt> queryScorebyCourseId(int CourseId)
        {
            string sql = "SELECT   CourseId,StuId, StuName, College, ClassScore, MatchScore, FinalScore, ClassId,CourseName, Xuefen, CollegeName from V_tea_score where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            List<ScoreExt> sclist = new List<ScoreExt>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                sclist.Add(new ScoreExt()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    College = result["College"].ToString(),
                    MatchScore = float.Parse(result["MatchScore"].ToString()),
                    ClassScore = float.Parse(result["ClassScore"].ToString()),
                    FinalScore = float.Parse(result["FinalScore"].ToString()),
                    ClassId = result["ClassId"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CollegeName = result["CollegeName"].ToString(),
                });
            }
            return sclist;
        }

        //教师查看某个学生的成绩(学号精确查找）
        public List<ScoreExt> queryScorebyCIdSId(int CourseId,int StuId)
        {
            string sql = "SELECT   CourseId,StuId, StuName, College, ClassScore, MatchScore, FinalScore, ClassId,CourseName, Xuefen, CollegeName from V_tea_score where CourseId = @CourseId and StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter ("@StuId",StuId)
            };
            List<ScoreExt> sclist = new List<ScoreExt>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                sclist.Add(new ScoreExt()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    College = result["College"].ToString(),
                    MatchScore = float.Parse(result["MatchScore"].ToString()),
                    ClassScore = float.Parse(result["ClassScore"].ToString()),
                    FinalScore = float.Parse(result["FinalScore"].ToString()),
                    ClassId = result["ClassId"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CollegeName = result["CollegeName"].ToString(),
                });
            }
            return sclist;
        }

        //教师查看某个学生的成绩(姓名模糊查找）
        public List<ScoreExt> queryScorebyCIdSNa(int CourseId, string Name)
        {
            string sql = "SELECT   CourseId,StuId, StuName, College, ClassScore, MatchScore, FinalScore, ClassId,CourseName, Xuefen, CollegeName from V_tea_score where CourseId = @CourseId and StuName Like  '%" + Name + "%'";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            List<ScoreExt> sclist = new List<ScoreExt>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                sclist.Add(new ScoreExt()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    College = result["College"].ToString(),
                    MatchScore = float.Parse(result["MatchScore"].ToString()),
                    ClassScore = float.Parse(result["ClassScore"].ToString()),
                    FinalScore = float.Parse(result["FinalScore"].ToString()),
                    ClassId = result["ClassId"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CollegeName = result["CollegeName"].ToString(),
                });
            }
            return sclist;
        }


        //教师查看某个班级的成绩
        public List<ScoreExt> queryScorebyClassId(int CourseId,string ClassId)
        {
            string sql = "SELECT   CourseId,StuId, StuName, College, ClassScore, MatchScore, FinalScore, ClassId,CourseName, Xuefen, CollegeName from V_tea_score where CourseId = @CourseId and ClassId = @ClassId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId),
                new SqlParameter("@ClassId",ClassId)
            };
            List<ScoreExt> sclist = new List<ScoreExt>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (result.Read())
            {
                sclist.Add(new ScoreExt()
                {
                    CourseId = Convert.ToInt32(result["CourseId"]),
                    StuId = Convert.ToInt32(result["StuId"]),
                    StuName = result["StuName"].ToString(),
                    College = result["College"].ToString(),
                    MatchScore = float.Parse(result["MatchScore"].ToString()),
                    ClassScore = float.Parse(result["ClassScore"].ToString()),
                    FinalScore = float.Parse(result["FinalScore"].ToString()),
                    ClassId = result["ClassId"].ToString(),
                    CourseName = result["CourseName"].ToString(),
                    Xuefen = float.Parse(result["Xuefen"].ToString()),
                    CollegeName = result["CollegeName"].ToString(),
                });
            }
            return sclist;
        }

        //查看课程的成绩的计算比例
        public CourseMana queryRatio(int CourseId)
        {
            string sql = "select CourseId,TeaId,MatchRatio,ClassRatio from CourseMana where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseId",CourseId)
            };
            CourseMana course = null;
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (res.Read())
            {
                course = new CourseMana()
                {
                    CourseID = Convert.ToInt32(res["CourseId"]),
                    TeaId = Convert.ToInt32(res["TeaId"]),
                    MatchRatio = float.Parse(res["MatchRatio"].ToString()),
                    ClassRatio = float.Parse(res["ClassRatio"].ToString())
                };
            }
            return course;
        }

        //更改成绩
        public int ChangeScore (Score sc)
        {
            string sql = "update Score set ClassScore = @ClassScore,MatchScore=@MatchScore,FinalScore=@FinalScore where CourseId =@CourseId and StuId = @StuId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassScore",sc.ClassScore),
                new SqlParameter("@MatchScore",sc.MatchScore),
                new SqlParameter("@FinalScore",sc.FinalScore),
                new SqlParameter("@CourseId",sc.CourseId),
                new SqlParameter("@StuId",sc.StuId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }
        
        //查询挂科数
        public int queryGKNum(int StuId)
        {
            string sql = "select count(*) from Score where StuId=@StuId and FinalScore<60";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }

        //查询优秀科数
        public int queryYXNum(int StuId)
        {
            string sql = "select count(*) from Score where StuId=@StuId and FinalScore>60";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",StuId)
            };
            return Convert.ToInt32(new Helper.SQLHelper().QuerySingleResult(sql, param, false));
        }
    }
}

