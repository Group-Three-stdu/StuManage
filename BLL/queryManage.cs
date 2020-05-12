using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class queryManage
    {
        /// <summary>
        /// 查询所有学院
        /// </summary>
        /// <returns></returns>
        public List<College> queryAllCol()
        {
            return new queryStudentService().queryAllCollege();
        }

        /// <summary>
        /// 查询某一学院的所有专业
        /// </summary>
        /// <param name="collegeId">需要查询的学院的ID</param>
        /// <returns>该学院的所有专业</returns>
        public List<Major> querAllMaj(string collegeId)
        {
            return new queryStudentService().queryAllMajor(collegeId);
        }

        /// <summary>
        /// 查询某一专业的所有班级
        /// </summary>
        /// <param name="collegeId"></param>
        /// <param name="majorId"></param>
        /// <returns></returns>
        public List<Class> querAllCla(string collegeId,string majorId)
        {
            return new queryStudentService().queryAllClass(collegeId, majorId);
        }
    }
}
