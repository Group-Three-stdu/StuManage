using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace 学生信息管理系统.Score
{
    public partial class TeaScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            int StuNumber = new CourseManege().QueryStuNum(CourseId);
            StuNum.Text = StuNumber.ToString();
            List<Model.Class> clalist = new CourseManege().queryClassByCourseId(CourseId);
            string ClassId;
            foreach (Class Class in clalist)
            {
                ClassId = Class.ClassId;
                ddlclass.Items.Add(ClassId);
            }
            List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
            DataList1.DataSource = stulist;
            DataList1.DataBind();
            int ScoreNum = new ScoreManage().queryCouseScoreNum(CourseId);
            //当前该课程只要有记录记录则无法在添加学生成绩，此处可扩展，
            if (ScoreNum > 0)
            {
                Button2.Enabled = false;
                Literal1.Text = "该课程已完成成绩录入";
            }

        }

        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            string StuName = txt_name.Text.Trim().ToString();
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuName(StuName);
            DataList1.DataSource = stulist;
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float matchratio = float.Parse(TextBox2.Text.Trim());
            float classratio = float.Parse(TextBox1.Text.Trim());
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            int result = new CourseManege().AddRatio(CourseId, matchratio, classratio);
            if(result ==1)
            {
                Response.Write("<script>window.alert('成功设置分数占比！');</script>");
                Button1.Enabled = false;
            }
            else
                Response.Write("<script>window.alert('分数占比设置失败！');</script>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox2.Text = (1 - float.Parse(TextBox1.Text.Trim())).ToString();
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = (1 - float.Parse(TextBox2.Text.Trim())).ToString();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            float matchratio = float.Parse(TextBox2.Text.Trim());
            float classratio = float.Parse(TextBox1.Text.Trim());
            for (int i = 0; i < DataList1.Items.Count; i++)
            {
                Model.Score sc = new Model.Score()
                {
                    StuId = Convert.ToInt32(((Literal)DataList1.Items[i].FindControl("StuId")).Text.Trim()),
                    CourseId = Convert.ToInt32(Request.Params["CourseId"]),
                    MatchScore = float.Parse(((TextBox)(DataList1.Items[i].FindControl("matchScore"))).Text),
                    ClassScore = float.Parse(((TextBox)(DataList1.Items[i].FindControl("classScore"))).Text),
                    FinalScore = float.Parse(((TextBox)(DataList1.Items[i].FindControl("matchScore"))).Text) * matchratio + float.Parse(((TextBox)(DataList1.Items[i].FindControl("classScore"))).Text) * classratio
                };
                int result = new ScoreManage().addStuScore(sc);
                if (result == 0)
                {
                    Response.Write("<script>window.alert('成功添加了" + i + "名同学的成绩，第" + i + 1 + "位同学成绩添加失败！');</script>");
                    break;
                }   
            }
            Response.Write("<script>window.alert('成功添加了" +DataList1.Items.Count+ "名同学的成绩');</script>");
        }


    }
}