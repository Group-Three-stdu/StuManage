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

                string id = "";
                string name;
                List<College> colList = new queryManage().queryAllCol();
                foreach (College a in colList)
                {
                    //ddlxueyuan.DataSource = new queryManage().queryAllCol();
                    //ddlxueyuan.DataBind();
                    ddlxueyuan.Items.Add(a.collegeName);
                    //queryManage bll = new queryManage();
                    //ddlxueyuan.DataSource = bll.queryAllCol();
                    //ddlxueyuan.DataTextField = a.collegeName;
                    //ddlxueyuan.DataValueField = a.collegeId;
                    //ddlxueyuan.DataBind();
                }

                //获取专业列表
                string majorid = "";
                string majorname;
                List<Major> majlist = new queryManage().querAllMaj(" ");
                foreach (Major m in majlist)
                {
                    majorid = m.majorId;
                    majorname = m.majorName;
                    ddlmajor.Items.Add(majorname);
                }

                //班级列表
                string classid;
                List<Class> clalist = new queryManage().querAllCla(" ", " ");
                foreach (Class c in clalist)
                {
                    classid = c.ClassId;
                    ddlclass.Items.Add(classid);
                }
            }
        }

        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            StudentManage bll = new StudentManage();
            if (name == "")
            {
                if ((ddlxueyuan.SelectedItem.Text != "" && ddlxueyuan.SelectedItem.Text != "请选择"))
                {
                    string college = Request.Form["ddlxueyuan"];
                    Repeater1.DataSource = bll.QueryStuByCollege(college);
                    Repeater1.DataBind();
                }
                else if (ddlmajor.SelectedItem.Text != " " && ddlmajor.SelectedItem.Text != "请选择")
                {
                    string major = Request.Form["ddlmajor"];
                    Repeater1.DataSource = bll.QueryStuByMajor(major);
                    Repeater1.DataBind();
                }
                else if (ddlclass.SelectedValue != " ")
                {
                    string classid = Request.Form["ddlclass"];
                    Repeater1.DataSource = bll.QueryStuByClassId(classid);
                    Repeater1.DataBind();
                }
            }
            else
            {
                Repeater1.DataSource = bll.QueryStuByName(name);
                Repeater1.DataBind();
            }
        }
    }
}