using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.qiandao
{
    public partial class kqDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int KQId = Convert.ToInt32(Request.Params["KQId"]);
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            List<Students> stuCheckedlist = new KqManage().queryCheckedStu(KQId);
            Repeater1.DataSource = stuCheckedlist;
            Repeater1.DataBind();
            List<Students> stuUnchecklist = new KqManage().queryUncheckStu(KQId, CourseId);
            Repeater2.DataSource = stuUnchecklist;
            Repeater2.DataBind();
        }
    }
}