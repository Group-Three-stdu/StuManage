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
    public partial class zuoye_xiangqing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
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
    }
}