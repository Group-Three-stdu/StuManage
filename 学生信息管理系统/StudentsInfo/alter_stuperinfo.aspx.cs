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
    public partial class alter_stuperinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int stuId = ((Model.Login)Session["CurrentUser"]).UserName;
            Students stu = new StudentManage().QueryStuById(stuId);
            txt_stuid.Text = stu.StuId.ToString();
            txt_stuname.Text = stu.StuName.ToString();
            txt_sex.Text = stu.StuSex.ToString();
            txt_birth.Text = stu.StuBirth.ToString();
            txt_address.Text = stu.StuAdd.ToString();
            txt_punish.Text = stu.Punish.ToString();
            txt_phone.Text = stu.StuPhoneNum.ToString();
            txt_honor.Text = stu.StuHonor.ToString();
            txt_xueyuan.Text = stu.College.ToString();
            txt_major.Text = stu.Major.ToString();
            txt_class.Text = stu.ClassId.ToString();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int stuId = ((Model.Login)Session["CurrentUser"]).UserName;
            Students stu = new StudentManage().QueryStuById(stuId);

        }
    }
}