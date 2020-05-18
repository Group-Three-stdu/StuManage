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
    public partial class zuoye_tijiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int HwId = Convert.ToInt32(Request.Params["HwId"]);
                Homework hw = new Homework();
                hw= new HomeworkManage().ShowHwDetail(HwId);
                HwHead.Text = hw.HwHead.Trim();
                HwContent.Text = hw.HwContent.Trim();
                StartTime.Text = hw.StartTime.ToString("yyyy-MM-dd HH:mm");
                EndTime.Text = hw.EndTime.ToString("yyyy-MM-dd HH:mm");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Answer_Stu ans = new Answer_Stu()
            {
                Time = DateTime.Now,
                StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName),
                HwId = Convert.ToInt32(Request.Params["HwId"]),
                Answer = editor1.Text
            };
            int result = new HomeworkManage().SubmitHw(ans);
            if(result>0)
                Response.Write("<script>window.alert('作业已提交！');</script>");
            else
                Response.Write("<script>window.alert('提交失败！');</script>");
        }
    }
}
    
