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
    public partial class addcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_save_Click(object sender, EventArgs e)
                   {
           
            CourseMes course = new CourseMes();
            CourseManege bll = new CourseManege();
            //course.CourseID= Convert.ToInt32(Request.Form["txt_id"]);
            course.CourseName= Request.Form["txt_name"];
            //course.TeaId= Convert.ToInt32(Request.Form["txt_tid"]);
            course.Xuefen= Convert.ToSingle(Request.Form["txt_xuefen"]);
            course.courseproperty = Request.Form["ddl_coursexingzhi"];
            course.CourseNum= Convert.ToInt32(Request.Form["txt_number"]);
            //course.SStatus= Request.Form["txt_zhuangtai"];
            course.TeaId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            course.CollegeName= Request.Form["ddl_college"];
            if (bll.AddCourseByTea(course) == 1)
            {
                Response.Write("<script>alert('添加成功');</script>");
            }else
            {
                Response.Write("<script>alert('添加失败');</script>");
            }
        }
    }
}