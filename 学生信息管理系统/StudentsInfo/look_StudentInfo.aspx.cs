using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.StudentsInfo
{
    public partial class look_StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int stuId = Convert.ToInt32(Request.QueryString["StuId"]);
            Students stu = new StudentManage().QueryStuById(stuId);
            StuId.Text = stu.StuId.ToString();
            StuName.Text = stu.StuName.ToString();
            StuSex.Text = stu.StuSex.ToString();
            StuBirth.Text = stu.StuBirth.ToString();
            StuAdd.Text = stu.StuAdd.ToString();
            pun.Text = stu.Punish.ToString();
            StuPho.Text = stu.StuPhoneNum.ToString();
            honor.Text = stu.StuHonor.ToString();
            Col.Text = stu.College.ToString();
            Major.Text = stu.Major.ToString();
            Class.Text = stu.ClassId.ToString();
        }
    }
}