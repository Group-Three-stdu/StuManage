using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    //学生管理
    public class StudentManage
    {
        //通过学号查询学生
        public Students QueryStuById(int StuId)
        {
            return new StudentService().queryStuById(StuId);
        }
        //通过班级编号查询信息
        public List<Students> QueryStuByClassId(string classId)
        {
            return new StudentService().queryStuByClassId(classId);
        }
        //通过学院编号查询信息
        public List<Students> QueryStuByCollege(string College)
        {
            return new StudentService().queryStuByCollege(College);
        }
        //通过专业查询信息
        public List<Students> QueryStuByMajor(string Major)
        {
            return new StudentService().queryStuByMajor(Major);
        }
        //综合查询
        public List<Students> QueryStu(int StuId, string StuName, string ClassId, string College, string Major)
        {
            return new StudentService().queryStu(StuId, StuName, ClassId, College, Major);
        }

        //通过姓名查询
        public List<Students> QueryStuByName(string Name)
        {
            return new StudentService().queryStuByName(Name);
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="StuId">学号</param>
        /// <returns>-1，删除失败，该学生有未完成的课程,1删除成功</returns>
        public int DeleteStudentById(int StuId)
        {
            int result = new StudentService().queryCourseByStuId(StuId);
            if (result > 0)
                return -1;
            return new StudentService().DleteStudent(StuId);
        }

        //修改学生信息
        public int UpdateStudentById(Students stu)
        {
            return new StudentService().UpdateStudent(stu);
        }
        //增加学生信息
        public int InsertStudent(Students stu)
        {
            return new StudentService().AddStudent(stu);
        }


    }
}
