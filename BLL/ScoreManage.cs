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

        /// <summary>
        /// 教师查看成绩
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public List<ScoreExt> queryScorebyCourseId(int CourseId)
        {
            return new ScoreService().queryScorebyCourseId(CourseId);
        }

        /// <summary>
        /// 教师查看某个学生的成绩(学号精确查找）
        /// </summary>
        /// <param name="CourseId"></param>
        /// <param name="StuId"></param>
        /// <returns></returns>
        public List<ScoreExt> queryScorebyCIdSId(int CourseId, int StuId)
        {
            return new ScoreService().queryScorebyCIdSId(CourseId, StuId);
        }

        /// <summary>
        /// 教师查看某个学生的成绩(姓名模糊查找）
        /// </summary>
        /// <param name="CourseId"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<ScoreExt> queryScorebyCIdSNa(int CourseId, string Name)
        {
            return new ScoreService().queryScorebyCIdSNa(CourseId, Name);
        }

        /// <summary>
        /// 教师查看某个学生的成绩（按班级）
        /// </summary>
        /// <param name="CourseId"></param>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public List<ScoreExt> queryScorebyClassId(int CourseId, string ClassId)
        {
            return new ScoreService().queryScorebyClassId(CourseId, ClassId);
        }

        /// <summary>
        /// 查看课程的计分比例
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public CourseMana queryRatio(int CourseId)
        {
            return new ScoreService().queryRatio(CourseId);
        }

        /// <summary>
        /// 更改成绩
        /// </summary>
        /// <param name="sc"></param>
        /// <returns></returns>
        public int ChangeScore(Score sc)
        {
            return new ScoreService().ChangeScore(sc);
        }
    }
}
