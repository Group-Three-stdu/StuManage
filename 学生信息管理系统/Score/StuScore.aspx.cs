using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.Score
{
    public partial class StuScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定下拉框
                int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
                List<CourseMana> Seasonlist = new CourseManege().querySeason(StuId);
                foreach (CourseMana Season in Seasonlist)
                {
                    ddlseason.Items.Add(Season.Season);
                }
                //显示数据
                List<Model.Score> sclist = new ScoreManage().queryScore(StuId);
                Repeater1.DataSource = sclist;
                Repeater1.DataBind();
            }
        }

        protected void btn_searchstu_Click(object sender, EventArgs e)
        {

        }
    }
}