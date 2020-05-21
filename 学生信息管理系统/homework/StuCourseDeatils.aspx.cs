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
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            List<Homework> hkList = new HomeworkManage().ShowStuHK(CourseId);
            DataList1.DataSource = hkList;
            DataList1.DataBind();
            List<KQ> KqList = new KqManage().queryAllKq(CourseId);
            DataList2.DataSource = KqList;
            DataList2.DataBind();
            List<JXGG> gglist = new GGManage().LookJXGG(CourseId);
            Repeater3.DataSource = gglist;
            Repeater3.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int HwId = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect("~/homework/zuoye_tijiao.aspx/?HwId=" + HwId);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int KQId = Convert.ToInt32(((Button)sender).CommandArgument);
            int StuId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            DateTime time = DateTime.Now;
            int result = new KqManage().AddKqRecord(StuId, KQId, time);
            if(result==1)
            {
                Response.Write("<script>window.alert('签到成功！');</script>");
                //Label lb = DataList2.Items[0].FindControl("Label1") as Label;
                //lb.Text = "已签到";
            }
                
            if(result!=1)
                Response.Write("<script>window.alert('请勿重复签到！');</script>");
        }
    }
}