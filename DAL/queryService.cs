using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class queryService
    {
        /// <summary>
        /// 查询学院信息
        /// </summary>
        /// <returns>所有学院信息</returns>
        public List<College> queryAllCollege()
        {
            string sql = "select college,collegeName from XY";
            List<College> collist = new List<College>();
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            while (result.Read())
            {
                collist.Add(new College()
                {
                    collegeId = result["college"].ToString(),
                    collegeName = result["collegeName"].ToString()
                });
            }
            return collist;
        }

        /// <summary>
        /// 查询所有专业
        /// </summary>
        /// <param name="collegeId">学院ID</param>
        /// <returns>该学院的所有专业</returns>
        public List<Major> queryAllMajor(string collegeId)
        {
            string sql = "select major,MajorName,College from ZY where 1=1";
            List<Major> majlist = new List<Major>();
            if (collegeId != " ")
                sql += " and college='" + collegeId + "'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql,  false);
            while (result.Read())
            {
                majlist.Add(new Major()
                {
                    majorId = result["Major"].ToString(),
                    majorName = result["MajorName"].ToString(),
                    collegeId = result["College"].ToString()
                });
            }
            return majlist;
        }


        /// <summary>
        /// 查询班级
        /// </summary>
        /// <param name="collegeId"></param>
        /// <param name="majorId"></param>
        /// <returns></returns>
        public List<Class> queryAllClass(string collegeId,string majorId)
        {
            string sql = "select classId,Major,college from Class where 1=1";
            List<Class > clalist = new List<Class>();
            if (collegeId != " ")
                sql += " and collegeId='" + collegeId + "'";
            if(majorId!=" ")
                sql+=" and majorId='"+majorId+"'";
            SqlDataReader result = new Helper.SQLHelper().queryAllResult(sql, false);
            while (result.Read())
            {
                clalist.Add(new Class()
                {
                    ClassId=result["classId"].ToString(),
                    collegId = result["college"].ToString(),
                    majorId = result["Major"].ToString()
                });
            }
            return clalist;
        }
    }
}
