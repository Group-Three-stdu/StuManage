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
        //对课程进行审批
        //protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    CourseManege bll = new CourseManege();
        //    int id = Convert.ToInt32(e.CommandArgument);
        //    if (e.CommandName.Equals("past"))
        //    {
        //        //bll.checkCourseToY(id,);
        //    }
        //    else if (e.CommandName.Equals("nopast"))
        //    {
        //        bll.checkCourseToN(id);
        //    }
        //}

        //添加到课程信息表中
        protected void btn_save_Click(object sender, EventArgs e)
        {
            
            int CourseId = Convert.ToInt32(Request.Form["courseId"]);
            CourseMana course = new CourseMana();
            CourseManege bll = new CourseManege();
            course.Season = Request.Form["txt_season"];
            course.Time = Request.Form["txt_time"];
            course.CourseAdd = Request.Form["txt_add"];
            if(bll.checkCourseToY(CourseId, course)==1)
            {
                Response.Write("<script>alert('审核课程成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('成功');</script>");
            }
        }
    }
    }
