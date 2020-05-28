using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.Class
{
    public partial class ClassDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ClassId = Convert.ToString(Request.Params["ClassId"]);
            classid.Text = ClassId.ToString();
            List<Students> stulist = new StudentManage().queryStudentByClassId(ClassId);
            foreach(Students stu in stulist)
            {
                stu.GKNum = new ScoreManage().queryGKNum(stu.StuId);
                stu.YXNum = new ScoreManage().queryYXNum(stu.StuId);
            }
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
        //姓名模糊查询
        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            string ClassId = Convert.ToString(Request.Params["ClassId"]);
            string StuName = txt_name.Text.Trim().ToString();
            List<Students> stulist = new StudentManage().FDYqueryStudentByStuName(StuName, ClassId);
            foreach (Students stu in stulist)
            {
                stu.GKNum = new ScoreManage().queryGKNum(stu.StuId);
                stu.YXNum = new ScoreManage().queryYXNum(stu.StuId);
            }
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
        //学号查询
        protected void btn_SearchStuId_Click(object sender, EventArgs e)
        {
            string ClassId = Convert.ToString(Request.Params["ClassId"]);
            int StuId = Convert.ToInt32(txt_StuId.Text.Trim());
            List<Students> stulist = new StudentManage().FDYqueryStudentByStuId(StuId, ClassId);
            foreach (Students stu in stulist)
            {
                stu.GKNum = new ScoreManage().queryGKNum(stu.StuId);
                stu.YXNum = new ScoreManage().queryYXNum(stu.StuId);
            }
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
    }
}