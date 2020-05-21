using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.Score
{
    public partial class TeaCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int TeaId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            List<CourseMes> courseList = new CourseManege().queryTeaCourse(TeaId);
            DataList1.DataSource = courseList;
            DataList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect("~/Score/TeaScore.aspx/?CourseId=" + CourseId);
        }
    }
}
