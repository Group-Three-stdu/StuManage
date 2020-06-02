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
    public partial class coursestate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int state = new CourseManege().queryCourseState();
                if (state == 0)
                    Button2.Enabled = false;
                else
                    Button1.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int res = new CourseManege().StartCourse();
            if (res == 1)
                Response.Write("<script type='text/javascript'>alert('开启选课成功！');</script>");
            else
                Response.Write("<script type='text/javascript'>alert('开启选课失败！');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int res = new CourseManege().StopCourse();
            if (res == 1)
                Response.Write("<script type='text/javascript'>alert('关闭选课成功！');</script>");
            else
                Response.Write("<script type='text/javascript'>alert('关闭选课失败！');</script>");
        }
    }
}