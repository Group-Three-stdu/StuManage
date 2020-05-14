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
    public partial class reviewcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //查看全部课程
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        //查看未审批的课程
        protected void Button2_Click(object sender, EventArgs e)
        {
            CourseManege bll = new CourseManege();
            Repeater1.DataSource = bll.showUncheck();
            Repeater1.DataBind();
        }
    }
}