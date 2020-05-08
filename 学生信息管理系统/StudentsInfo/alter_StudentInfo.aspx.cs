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
    public partial class alter_StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int stuId = Convert.ToInt32(Request.QueryString["StuId"]);
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

        protected void btn_save_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Request.QueryString["StuId"]);
            StudentManage bll = new StudentManage();
            Students stu = new Students();
            stu.StuId = Convert.ToInt32(txt_stuid.Text);
            stu.StuName = txt_stuname.Text;
            stu.StuSex = txt_sex.Text;
            stu.StuBirth = txt_birth.Text;
            stu.StuAdd = txt_address.Text;
            stu.Punish = txt_punish.Text;
            stu.StuPhoneNum = txt_phone.Text;
            stu.StuHonor = txt_honor.Text;
            stu.College = txt_xueyuan.Text;
            stu.Major = txt_major.Text;
            stu.ClassId = txt_class.Text;
            stu.StuNoId = txt_noid.Text;
            stu.StuState = txt_ps.Text;
            stu.PoliticalStatus = txt_mianmao.Text;

            if (bll.UpdateStudentById(stu)==1)
            {
                Response.Write("<script>alert('成功');</script>");
            }else
            {
                Response.Write("<script>alert('失败');</script>");
            }
        }
    }
}