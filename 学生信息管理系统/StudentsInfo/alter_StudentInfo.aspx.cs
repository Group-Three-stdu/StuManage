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
            if (!IsPostBack)
            {
                int stuId = Convert.ToInt32(Request.QueryString["StuId"]);
                Students stu = new StudentManage().QueryStuById(stuId);
                this.Id.Text = stu.StuId.ToString();
                Name.Text = stu.StuName.ToString();
                Sex.Text = stu.StuSex.ToString();
                Birth.Text = stu.StuBirth.ToString();
                Add.Text = stu.StuAdd.ToString();
                Stupun.Text = stu.Punish.ToString();
                Pho.Text = stu.StuPhoneNum.ToString();
                Stuhonor.Text = stu.StuHonor.ToString();
                ColName.Text = stu.CollegeName.ToString();
                Maj.Text = stu.MajorName.ToString();
                ClassId.Text = stu.ClassId.ToString();
                IdNo.Text = stu.StuNoId.ToString();
                StupoState.Text = stu.PoliticalStatus.ToString();
                CollegeID.Text = stu.College.ToString();
                Major.Text = stu.Major.ToString();
            }
        }

        protected void btn_sub_Click(object sender, EventArgs e)
        {
            Students stu = new Students()
            {
                StuId = Convert.ToInt32(Request.Params["StuId"]),
                StuName = Name.Text.Trim(),
                StuSex = Sex.Text.Trim(),
                StuBirth = Birth.Text.Trim(),
                Punish = Stupun.Text.Trim(),
                StuHonor = Stuhonor.Text.Trim(),
                StuPhoneNum = Pho.Text.Trim(),
                StuNoId = IdNo.Text.Trim(),
                StuState = StupoState.Text.Trim(),
                ClassId = ClassId.Text.Trim(),
                StuAdd = Add.Text.Trim(),
                College = CollegeID.Text.Trim(),
                Major = Major.Text.Trim(),
                PoliticalStatus = StupoState.Text.Trim()
            };
            int res = new StudentManage().UpdateStudentById(stu);
            if (res > 0)
                Response.Write("<script>alert('修改成功')</script>");
            else
                Response.Write("<script>alert('修改失败')</script>");
        }
    }
}