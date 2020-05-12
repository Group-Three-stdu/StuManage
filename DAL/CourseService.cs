using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CourseService
    {
        /// <summary>
        ///查询课程性质（删除之前）
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public int queryCouresProperty(string CourseId)
        {
            string sql = "select courseproperty from CoursesMes where CourseId = @CourseId";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@CourseId",CourseId)
          };
            object result = new Helper.SQLHelper().QuerySingleResult(sql, param, false);
            if ((result.ToString()).Equals("必修"))
                return 0;
            return 1;
        }


        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="Selected_courseid"></param>
        /// <returns></returns>
        public int deleteSelectedCourse(string Selected_courseid)
        {
            string sql = "delete from Courses_Stu where [Selected_courseid]=@Selected_courseid";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Selected_courseid",Selected_courseid)
            };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }
    }
}
