using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.GG
{
    public partial class fabu_gg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            JXGG gg = new JXGG()
            {
                TeaId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName),
                Time = DateTime.Now,
                CourseId = Convert.ToInt32(Request.Params["CourseId"]),
                GGHead = GGHead.Text.Trim().ToString(),
                GGContent = editor1.Text
            };
            int result = new GGManage().fabuGG(gg);
            if (result > 0)
            {
                Literal1.Text = "<script type='text/javascript'>alert('公告发布成功！');</script>";
                btn_submit.Enabled = false;
            }
            else
                Literal1.Text = "<script type='text/javascript'>alert('作业发布失败！');</script>";
        }
    }
}