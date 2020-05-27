using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.homework
{
    public partial class lookfinishedHw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int StuId = Convert.ToInt32(Request.Params["StuId"]);
                int HwId = Convert.ToInt32(Request.Params["HwId"]);
                Answer_Stu ans = new HomeworkManage().queryStuAnsByStuId(StuId, HwId);
                Homework hw = new HomeworkManage().ShowHwDetail(HwId);
                HwContent.Text = hw.HwContent.ToString();
                answer.Text = ans.Answer.ToString();
                ViewState["UrlReferrer"] = Request.UrlReferrer.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["UrlReferrer"] != null)
            {
                Response.Redirect(ViewState["UrlReferrer"].ToString());
            }
        }
    }
}