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
    public partial class stu_xuanke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int state = new CourseManege().queryCourseState();
                if (state != 1)
                    Response.Write("<script type='text/javascript'>alert('学生选课未开启！');history.go(-1)</script>");
            }
            CourseManege bll = new CourseManege();
            Repeater1.DataSource = bll.queryAllCourse();
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text.Trim().ToString();
            List < CourseMana > courselist = new CourseManege().queryCourseByName(name);
            Repeater1.DataSource = courselist;
            Repeater1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            int CourseId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int result = new CourseManege().chooseCourse(CourseId, StuId);
            if (result > 0)
                Itamsg.Text = "<script>alert('添加成功！')</script>";
            else if (result == -1)
                Itamsg.Text = "<script>alert('该课程已添加！')</script>";
            else if (result == -2)
                Itamsg.Text = "<script>alert('学分超过上限！')</script>";
            else
                Itamsg.Text = "<script>alert('添加失败！')</script>";
        }
    }
}