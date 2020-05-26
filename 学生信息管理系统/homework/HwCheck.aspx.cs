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
    public partial class HwCheck : System.Web.UI.Page
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
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(Request.Params["StuId"]);
            int HwId = Convert.ToInt32(Request.Params["HwId"]);
            string Grade = Score.Text.Trim();
            string Resist = editor1.Text.Trim();
            int res = new HomeworkManage().TeaCheckAns(Grade, Resist, StuId, HwId);
            if (res > 0)
            {
                Response.Write("<script>alert('批阅成功！');history.go(-2)</script>");
            }
            else
            {
                Response.Write("<script>alert('批阅失败！');</script>");
            }

        }
    }
}