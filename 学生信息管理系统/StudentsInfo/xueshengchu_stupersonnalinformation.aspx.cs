using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace 学生信息管理系统
{
    public partial class xueshengchu_stupersonnalinformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 5;
            //lb_count.Text = "共有" + "&nbsp;" + count + "&nbsp;" + "条数据";
            if (!IsPostBack)
            {
                //获取学院列表
                List<College> colList = new queryManage().queryAllCol();
                ddlxueyuan.DataSource = colList;
                ddlxueyuan.DataTextField = "collegeName";
                ddlxueyuan.DataValueField = "collegeId";
                ddlxueyuan.DataBind();
                ddlxueyuan.Items.Insert(0, new ListItem("请选择", ""));
                //获取专业列表
                List<Major> majlist = new queryManage().querAllMaj(" ");
                ddlmajor.DataSource = majlist;
                ddlmajor.DataTextField = "majorName";
                ddlmajor.DataValueField = "majorId";
                ddlmajor.DataBind();
                ddlmajor.Items.Insert(0, new ListItem("请选择", ""));
                //班级列表
                List<Model.Class> clalist = new queryManage().querAllCla(" ", " ");
                ddlclass.DataSource = clalist;
                ddlclass.DataTextField = "ClassId";
                ddlclass.DataBind();
                ddlclass.Items.Insert(0, new ListItem("请选择", ""));

                Repeater1.DataSource = new StudentManage().QueryStu(0, "", "", "","");
                Repeater1.DataBind();
            }
        }

        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            StudentManage bll = new StudentManage();
            int StuId = 0;
            if (txt_id.Text.Trim() != "")
                StuId = Convert.ToInt32(txt_id.Text.Trim());
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            string majorId = ddlmajor.SelectedValue.Trim().ToString();
            string classId = ddlclass.SelectedValue.Trim().ToString();
            Repeater1.DataSource = new StudentManage().QueryStu(StuId,name,classId ,collegeId, majorId);
            Repeater1.DataBind();

        }
        //学院下拉框改变
        protected void ddlxueyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string college =ddlxueyuan.SelectedItem.Value.Trim().ToString();
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            List<Students> stuList = new StudentManage().QueryStu(0,"","",college,"");
            Repeater1.DataSource = stuList;
            Repeater1.DataBind();
            //专业下拉框联动
            List<Major> majlist = new queryManage().querAllMaj(collegeId);
            ddlmajor.DataSource = majlist;
            ddlmajor.DataTextField = "majorName";
            ddlmajor.DataValueField = "majorId";
            ddlmajor.DataBind();
            ddlmajor.Items.Insert(0, new ListItem("请选择", ""));
            //班级下拉框联动
            List<Model.Class> clalist = new queryManage().querAllCla(collegeId, " ");
            ddlclass.DataSource = clalist;
            ddlclass.DataTextField = "ClassId";
            ddlclass.DataBind();
            ddlclass.Items.Insert(0, new ListItem("请选择", ""));
        }
        //专业下拉框改变
        protected void ddlmajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string college = ddlxueyuan.SelectedItem.Value.Trim().ToString();
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            string majorId = ddlmajor.SelectedValue.Trim().ToString();
            List<Students> stuList = new StudentManage().QueryStu(0, "", "", college, majorId);
            Repeater1.DataSource = stuList;
            Repeater1.DataBind();
            //班级下拉框联动
            List<Model.Class> clalist = new queryManage().querAllCla(collegeId, majorId);
            ddlclass.DataSource = clalist;
            ddlclass.DataTextField = "ClassId";
            ddlclass.DataBind();
            ddlclass.Items.Insert(0, new ListItem("请选择", ""));
        }
        //班级下拉框改变
        protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string college = ddlxueyuan.SelectedItem.Value.Trim().ToString();
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            string majorId = ddlmajor.SelectedValue.Trim().ToString();
            string classId = ddlclass.SelectedValue.Trim().ToString();
            List<Students> stuList = new StudentManage().QueryStu(0, "", classId, college, majorId);
            Repeater1.DataSource = stuList;
            Repeater1.DataBind();
        }
        //删除学生
        protected void btn_Del_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int res = new StudentManage().DeleteStudentById(StuId);
            if (res > 0)
                System.Web.UI.ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "", "alert('删除成功');", true);
            else if (res == -1)
                System.Web.UI.ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "", "alert('该学生有未完成的课程无法删除');", true);
            else
             System.Web.UI.ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "", "alert('删除失败');", true);
        }
    }
}