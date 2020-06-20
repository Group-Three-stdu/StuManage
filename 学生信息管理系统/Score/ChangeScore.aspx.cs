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
    public partial class ChangeScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int stuId = Convert.ToInt32(Request.Params["StuId"]);
                int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
                List<ScoreExt> sclist = new ScoreManage().queryScorebyCIdSId(CourseId,stuId);
                CourseMana course = new ScoreManage().queryRatio(CourseId);
                MatchRatio.Text = course.MatchRatio.ToString();
                ClassRatio.Text = course.ClassRatio.ToString();
                StuName.Text = sclist[0].StuName.ToString();
                StuId.Text = sclist[0].StuId.ToString();
                CourseName.Text = sclist[0].CourseName.ToString();
                old_ClassScore.Text = sclist[0].ClassScore.ToString();
                old_MatchScore.Text = sclist[0].MatchScore.ToString();
                old_FinalScore.Text = sclist[0].FinalScore.ToString();
            }     
        }

        protected void new_ClassScore_TextChanged(object sender, EventArgs e)
        {
            if (new_MatchScore.Text == "" || new_ClassScore.Text == "")
                return;
            new_FinalScore.Text = (float.Parse(new_MatchScore.Text) * float.Parse(MatchRatio.Text) + float.Parse(new_ClassScore.Text) * float.Parse(ClassRatio.Text)).ToString();
        }

        protected void new_MatchScore_TextChanged(object sender, EventArgs e)
        {
            if (new_MatchScore.Text == "" || new_ClassScore.Text == "")
                return;
            new_FinalScore.Text = (float.Parse(new_MatchScore.Text) * float.Parse(MatchRatio.Text) + float.Parse(new_ClassScore.Text) * float.Parse(ClassRatio.Text)).ToString();
        }

        protected void btn_change_Click(object sender, EventArgs e)
        {



            Model.Score sc = new Model.Score()
            {
                StuId = Convert.ToInt32(Request.Params["StuId"]),
                CourseId = Convert.ToInt32(Request.Params["CourseId"]),
                ClassScore = float.Parse(new_ClassScore.Text.ToString().Trim()),
                MatchScore = float.Parse(new_MatchScore.Text.ToString().Trim()),
                FinalScore = float.Parse(new_FinalScore.Text.ToString().Trim()),
            };
            int res = new ScoreManage().ChangeScore(sc);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功！');history.go(-2)</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}