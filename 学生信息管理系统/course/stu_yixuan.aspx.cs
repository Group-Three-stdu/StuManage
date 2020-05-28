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
    public partial class stu_yixuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            List<CourseMana> courlist = new CourseManege().queryAllCourseByStuId(StuId);
            Repeater1.DataSource = courlist;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int stuid= Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            CourseManege bll = new CourseManege();
            Repeater1.DataSource = bll.showSelectCourse(stuid);
            Repeater1.DataBind();
        }

        protected void btn_Del_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            int res = new CourseManege().DeleteSelectedCourse(CourseId,StuId);
            if (res > 0)
                Response.Write("<script>alert('删除成功');</Script>");
            else if (res == -1)
                Response.Write("<script>alert('必修课无法删除');</Script>");
            else
                Response.Write("<script>alert('删除失败');</Script>");
        }
    }
}