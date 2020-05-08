using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    //学生管理。。
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

        //删除学生
        public int DeleteStudentById(int StuId)
        {
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
