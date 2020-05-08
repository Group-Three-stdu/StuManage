using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统
{
    public partial class stu_look_personalinformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int stuId = ((Model.Login)Session["CurrentUser"]).UserName;
            Students stu = new StudentManage().QueryStuById(stuId);
           
        }
    }
}