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
    }
}
