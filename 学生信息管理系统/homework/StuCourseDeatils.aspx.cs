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
    public partial class StuCourseDeatils : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int StuId = ((Model.Login)Session["CurrentUser"]).UserName;
                int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
                coursename.Text = (new CourseManege().queryCourseById(CourseId)).CourseName;
                //绑定未完成作业
                List<Homework> ufhkList = new HomeworkManage().queryUnfinishedHw(CourseId, StuId);
                DataList1.DataSource = ufhkList;
                DataList1.DataBind();
                //绑定已完成作业
                List<Homework> fhkList = new HomeworkManage().queryfinishedHw(CourseId, StuId);
                DataList3.DataSource = fhkList;
                DataList3.DataBind();
                //绑定已审批作业
                List<Homework> chkList = new HomeworkManage().queryfinishedHw(CourseId, StuId);
                DataList4.DataSource = chkList;
                DataList4.DataBind();
                //绑定考勤
                List<KQ> KqList = new KqManage().queryAllKq(CourseId);
                foreach (KQ kq in KqList)
                {
                    int State = new KqManage().HasChecked(StuId, kq.KQId);
                    if (State > 0)
                        kq.state = "已签到";
                    else
                        kq.state = "<span style='color:red;'>未签到<span>";
                }
                DataList2.DataSource = KqList;
                DataList2.DataBind();
                //绑定公告
                List<JXGG> gglist = new GGManage().LookJXGG(CourseId);
                Repeater3.DataSource = gglist;
                Repeater3.DataBind();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect("~/homework/zuoye_tijiao.aspx/?HwId=" + HwId);
        }
        //签到
        protected void Button3_Click(object sender, EventArgs e)
        {
            int KQId = Convert.ToInt32(((Button)sender).CommandArgument);
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            DateTime time = DateTime.Now;
            int result = new KqManage().AddKqRecord(StuId, KQId, time);
            if(result==1)
            {
                Response.Write("<script>window.alert('签到成功！');</script>");
            }
            if(result==-1)
                Response.Write("<script>window.alert('请勿重复签到！');</script>");
            if(result==-2)
                Response.Write("<script>window.alert('签到超时！');</script>");
        }

        //已完成作业查看
        protected void finished_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            int StuId = ((Model.Login)Session["CurrentUser"]).UserName;
            Response.Redirect("~/homework/lookfinishedHw.aspx/?HwId=" + HwId+"&StuId="+StuId);
        }
        //查看已批阅作业
        protected void check_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            int StuId = ((Model.Login)Session["CurrentUser"]).UserName;
            Response.Redirect("~/homework/lookcheckedHw.aspx/?HwId=" + HwId + "&StuId=" + StuId);
        }
    }
}