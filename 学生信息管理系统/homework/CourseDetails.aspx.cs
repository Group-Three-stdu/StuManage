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
    public partial class CourseDetails : System.Web.UI.Page
    {
        public int StuNum = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            StuNum = new CourseManege().QueryStuNum(CourseId);
            List<Model.Class> clalist = new CourseManege().queryClassByCourseId(CourseId);
            string ClassId;
            foreach (Class Class in clalist)
            {
                ClassId = Class.ClassId;
                ddlclass.Items.Add(ClassId);
            }
            foreach (Class Class in clalist)
            {
                ClassId = Class.ClassId;
                DropDownList1.Items.Add(ClassId);
            }
            List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
            DataList1.DataSource = stulist;
            DataList1.DataBind();
            List<Homework> HwList = new HomeworkManage().queryAllHKByTea(CourseId);
            DataList2.DataSource = HwList;
            DataList2.DataBind();
            List<KQ> KqList = new KqManage().queryAllKq(CourseId);
            DataList3.DataSource = KqList;
            DataList3.DataBind();
        }

        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            string StuName = txt_name.Text.Trim().ToString();
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuName(StuName);
            DataList1.DataSource = stulist;
            DataList1.DataBind();
        }

        protected void btn_searchStuId_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void fabu_qiandao_click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            Response.Redirect("~/qiandao/fabu_qiandao.aspx?CourseId="+ CourseId);
        }
    }
}