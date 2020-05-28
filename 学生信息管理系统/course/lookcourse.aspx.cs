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
    public partial class lookcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CourseManege bll = new CourseManege();
            Repeater1.DataSource = bll.queryAllCourse();
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text.Trim().ToString();
            List<CourseMana> courselist = new CourseManege().queryCourseByName(name);
            Repeater1.DataSource = courselist;
            Repeater1.DataBind();
        }

    }
}