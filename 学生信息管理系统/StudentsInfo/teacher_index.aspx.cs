using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace 学生信息管理系统.StudentsInfo
{
    public partial class teacher_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_user.Text = ((Model.Login)Session["CurrentUser"]).StuName.ToString();
            lb_time.Text = DateTime.Now.ToString();
        }
    }
}