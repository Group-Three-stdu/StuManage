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
    public partial class teainfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int TeaId = ((Model.Login)Session["CurrentUser"]).UserName;
                Teacher stu = new TeaManage().queryTeainfoById(TeaId);
                this.TeaId.Text = stu.TeaId.ToString();
                Name.Text = stu.TeaName.ToString();
                Sex.Text = stu.TeaSex.ToString();
                Birth.Text = stu.TeaBirth.ToString();
                Add.Text = stu.TeaAdd.ToString();
                Pho.Text = stu.Phone.ToString();
                Honor.Text = stu.TeaHonor.ToString();
                Job.Text = stu.Job.ToString();
                ColName.Text = stu.CollegeName.ToString();
                Office.Text = stu.Office.ToString();
                IdNo.Text = stu.TeaNoId.ToString();
                StupoState.Text = stu.PoliticalStatus.ToString();
                CollegeID.Text = stu.College.ToString();
                Image1.ImageUrl = "~/image/teacher/" + TeaId + ".jpg";
            }
        }

        protected void btn_sub_Click(object sender, EventArgs e)
        {
            Teacher tea = new Teacher()
            {
                TeaId = ((Model.Login)Session["CurrentUser"]).UserName,
                Phone = Pho.Text.Trim(),
                TeaAdd = Add.Text.Trim(),
                Office = Office.Text.Trim()
            };
            int res = new TeaManage().alterTeainfo(tea);
            if (res > 0)
                Response.Write("<script>alert('修改成功')</script>");
            else
                Response.Write("<script>alert('修改失败')</script>");
        }
    }
}