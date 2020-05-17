using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.homework
{
    public partial class zuoye_chakan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            List<Homework> hkList = new HomeworkManage().ShowStuHK(CourseId);
            DataList1.DataSource = hkList;
            DataList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect("~/homework/zuoye_tijiao.aspx/?HwId=" + HwId);
        }
    }
}