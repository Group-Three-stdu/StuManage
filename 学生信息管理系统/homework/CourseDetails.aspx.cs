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
            if (!IsPostBack)
            {
                int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
                StuNum = new CourseManege().QueryStuNum(CourseId);
                coursename.Text = (new CourseManege().queryCourseById(CourseId)).CourseName;
                List<Model.Class> clalist = new CourseManege().queryClassByCourseId(CourseId);
                string ClassId;
                foreach (Model.Class Class in clalist)
                {
                    ClassId = Class.ClassId;
                    ddlclass.Items.Add(ClassId);
                }
                List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
                foreach(Students stu in stulist)
                {
                    stu.KqNum = new KqManage().queryStuKqNum(stu.StuId, CourseId);
                    stu.HwNum = new HomeworkManage().queryStuHwNum(stu.StuId, CourseId);
                }
                Repeater1.DataSource = stulist;
                Repeater1.DataBind();
                List<Homework> HwList = new HomeworkManage().queryAllHKByTea(CourseId);
                DataList2.DataSource = HwList;
                DataList2.DataBind();
                List<KQ> KqList = new KqManage().queryAllKq(CourseId);
                Repeater2.DataSource = KqList;
                Repeater2.DataBind();
                List<JXGG> gglist = new GGManage().LookJXGG(CourseId);
                Repeater3.DataSource = gglist;
                Repeater3.DataBind();
            }
        }
        //通过姓名模糊查询
        protected void btn_searchstu_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            string StuName = txt_name.Text.Trim().ToString();
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuName(StuName, CourseId);
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
        //通过学号查学生
        protected void btn_searchStuId_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(txt_StuId.Text.Trim());
            List<Students> stulist = new StudentManage().TeaqueryStudentByStuId(StuId);
            Repeater1.DataSource = stulist;
            Repeater1.DataBind();
        }
        //查看作业详情
        protected void Button2_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            Response.Redirect("~/homework/HwDetails.aspx?CourseId=" + CourseId + "&HwId=" + HwId);
        }
        //发布签到
        protected void fabu_qiandao_click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            string CourseName = (new CourseManege().queryCourseById(CourseId)).CourseName;
            Response.Redirect("~/qiandao/fabu_qiandao.aspx?CourseId=" + CourseId + "&CourseName=" + CourseName);
        }
        //发布作业
        protected void btn_fabu_zuoye_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            Response.Redirect("~/homework/fabu_zuoye.aspx?CourseId=" + CourseId);
        }
        //发布公告
        protected void fabu_GG_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            Response.Redirect("~/GG/fabu_gg.aspx?CourseId=" + CourseId);
        }
        //删除公告
        protected void btnDel_Click(object sender, EventArgs e)
        {
            int GGId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int result = new GGManage().DelGG(GGId);
            if (result > 0)
                Response.Write("<script>window.alert('公告已删除！');</script>");
            else
                Response.Write("<script>window.alert('删除失败！');</script>");
        }
        //签到详情
        protected void btnDetail_Click(object sender, EventArgs e)
        {
            int KQId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            Response.Redirect("~/qiandao/kqDetails.aspx?CourseId=" + CourseId + "&KQId=" + KQId);
        }
        //导出excel
        protected void ToExcel_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            string CourseName = (new CourseManege().queryCourseById(CourseId)).CourseName;
            Response.Redirect("~/Handler/TeaToExcel.ashx?CourseId=" + CourseId + "&CourseName=" + CourseName);
        }


        protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ClassId = ddlclass.SelectedItem.Text.Trim();
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            if (ClassId == "请选择")
            {
                List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
                Repeater1.DataSource = stulist;
                Repeater1.DataBind();
            }else
            {
                List<Students> stuList = new StudentManage().TeaqueryStudentByClassId(CourseId, ClassId);
                Repeater1.DataSource = stuList;
                Repeater1.DataBind();
            } 
        }
    }
}