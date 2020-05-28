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
    public partial class Tea_look_score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
                List<ScoreExt> sclist = new ScoreManage().queryScorebyCourseId(CourseId);
                Repeater1.DataSource = sclist;
                Repeater1.DataBind();
                //绑定下拉框
                List<Model.Class> clalist = new CourseManege().queryClassByCourseId(CourseId);
                string ClassId;
                foreach (Model.Class Class in clalist)
                {
                    ClassId = Class.ClassId;
                    ddlclass.Items.Add(ClassId);
                }
                //显示计分比例
                CourseMana course = new ScoreManage().queryRatio(CourseId);
                MatchRatio.Text = course.MatchRatio.ToString();
                ClassRatio.Text = course.ClassRatio.ToString();
            }
        }

        //通过姓名模糊查询
        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            string StuName = txt_name.Text.Trim().ToString();
            List<ScoreExt> sclist = new ScoreManage().queryScorebyCIdSNa(CourseId, StuName);
            Repeater1.DataSource = sclist;
            Repeater1.DataBind();
        }

        //通过学号查学生
        protected void btn_searchStuId_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            int StuId = Convert.ToInt32(txt_StuId.Text.Trim());
            if (StuId == 0)
                return;
            List<ScoreExt> sclist = new ScoreManage().queryScorebyCIdSId(CourseId, StuId);
            Repeater1.DataSource = sclist;
            Repeater1.DataBind();
        }

        protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ClassId = ddlclass.SelectedItem.Text.Trim();
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            if (ClassId == "请选择")
            {
                List<ScoreExt> sclist = new ScoreManage().queryScorebyCourseId(CourseId);
                Repeater1.DataSource = sclist;
                Repeater1.DataBind();
            }
            else
            {
                List<ScoreExt> sclist = new ScoreManage().queryScorebyClassId(CourseId, ClassId);
                Repeater1.DataSource = sclist;
                Repeater1.DataBind();
            }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            int StuId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            Response.Redirect("~/Score/ChangeScore.aspx/?CourseId=" + CourseId + "&StuId=" + StuId);
        }
    }
}