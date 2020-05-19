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
    public partial class fabu_qiandao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime KqTime = DateTime.Now;
            int minutes = Convert.ToInt32(TextBox1.Text.Trim());
            KQ kq = new KQ()
            {
                CourseId = Convert.ToInt32(Request.Params["CourseId"]),
                KqTime = DateTime.Now,
                EndTime = KqTime.AddMinutes(minutes)
            };
            int result = new KqManage().publishAttendance(kq);
            if(result>0)
                Response.Write("<script>window.alert('发布成功！');</script>");
        }
    }
}