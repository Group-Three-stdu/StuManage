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
    public partial class fabu_zuoye : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            Homework hw = new Homework()
            {
                StartTime = DateTime.Now,
                EndTime = Convert.ToDateTime(EndTime.Text),
                CourseId = Convert.ToInt32(Request.Params["CourseId"]),
                HwHead = HwHead.Text.Trim().ToString(),
                HwContent = editor1.Text
            };
            int result = new HomeworkManage().fabuHw(hw);
            if (result > 0)
            {
                Literal1.Text = "<script type='text/javascript'>alert('作业发布成功！');</script>";
                btn_submit.Enabled = false;
            }            
            else
                Literal1.Text = "<script type='text/javascript'>alert('作业发布失败！');</script>";
        }
    }
}