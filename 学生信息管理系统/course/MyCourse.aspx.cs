using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.course
{
    public partial class MyCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            List<CourseMana> courseList = new CourseManege().queryAllCourseByStuId(StuId);
            DataList1.DataSource = courseList;
            DataList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect("~/homework/zuoye_chakan.aspx/?CourseId=" + CourseId);
        }
    }
}