using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ScoreManage
    {

        /// <summary>
        /// 增加学生成绩
        /// </summary>
        /// <param name="sc"></param>
        /// <returns></returns>
        public int addStuScore(Score sc)
        {
            return new ScoreService().addStuScore(sc);
        }

        /// <summary>
        /// 查询某课程的成绩记录条数
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public int queryCouseScoreNum(int CourseId)
        {
            return new ScoreService().queryCouseScoreNum(CourseId);
        }

        /// <summary>
        /// 学生查看成绩
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<Score> queryScore(int StuId)
        {
            return new ScoreService().queryScore(StuId);
        }

        /// <summary>
        /// 通过学期查询分数
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public List<Score> queryScoreBySea(int StuId,string season)
        {
            return new ScoreService().queryScoreBySea(StuId,season);
        }

        /// <summary>
        /// 通过课程名模糊查询成绩
        /// </summary>
        /// <param name="StuId"></param>
        /// <param name="name"></param>
        /// <param name="Season"></param>
        /// <returns></returns>
        public List<Score> queryScoreByName(int StuId, string name,string Season)
        {
            if (Season == "请选择")
            {
                return new ScoreService().queryScoreBySeaByName(StuId, name);
            }
            return new ScoreService().queryScoreBySeaByName(StuId, Season,name);
        }
    }
}
