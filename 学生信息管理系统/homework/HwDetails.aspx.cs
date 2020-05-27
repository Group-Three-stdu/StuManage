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
    public partial class HwDetails : System.Web.UI.Page
    {
        int StuNum;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
                int HwId = Convert.ToInt32(Request.Params["HwId"]);
                StuNum = new CourseManege().QueryStuNum(CourseId);
                List<Model.Class> clalist = new CourseManege().queryClassByCourseId(CourseId);
                string ClassId;
                foreach (Class Class in clalist)
                {
                    ClassId = Class.ClassId;
                    ddlclass.Items.Add(ClassId);
                }
                List<Answer_Stu> ansList = new HomeworkManage().querySubmitedStu(HwId);
                Repeater1.DataSource = ansList;
                Repeater1.DataBind();
                List<Students> stulist = new HomeworkManage().queryUnsubmitStuId(HwId,CourseId);
                Repeater2.DataSource = stulist;
                Repeater2.DataBind();

            }
            }
        //下拉框改变
        protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ClassId = ddlclass.SelectedItem.Text.Trim();
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            if (ClassId == "请选择")
            {
                List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
                Repeater1.DataSource = stulist;
                Repeater1.DataBind();
            }
            else
            {
                List<Students> stuList = new StudentManage().TeaqueryStudentByClassId(CourseId, ClassId);
                Repeater1.DataSource = stuList;
                Repeater1.DataBind();
            }
        }
        //姓名模糊查询
        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            string StuName = txt_name.Text.Trim().ToString();
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuName(StuName, CourseId);
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
        //学号精确查询
        protected void btn_searchStuId_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(txt_StuId.Text.Trim());
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuId(StuId);
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }

        protected void btnLook_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(Request.Params["HwId"]);
            int StuId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            Response.Redirect("~/homework/HwCheck.aspx/?HwId=" + HwId + "&StuId=" + StuId);
        }
    }
}