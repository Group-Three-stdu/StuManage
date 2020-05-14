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
            //StuId.Text = ((Model.Login)Session["CurrentUser"]).UserName.ToString();
            //StuName.Text = ((Model.Login)Session["CurrentUser"]).StuName.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CourseManege bll = new CourseManege();
            Repeater1.DataSource = bll.queryAllCourse();
            Repeater1.DataBind();
        }
    }
}