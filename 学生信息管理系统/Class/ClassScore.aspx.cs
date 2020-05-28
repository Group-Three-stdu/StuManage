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
    public partial class ClassScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ClassId = Request.Params["ClassId"].ToString();
            int CourseId = Convert.ToInt32(Request.Params["CourseId"]);
            List<ScoreExt> sclist = new ScoreManage().queryScorebyFDY(CourseId, ClassId);
            foreach (ScoreExt sc in sclist)
            {
                sc.KqNum = new KqManage().queryStuKqNum(sc.StuId, sc.CourseId);
                sc.HwNum = new HomeworkManage().queryStuHwNum(sc.StuId, sc.CourseId);
            }
            Repeater1.DataSource = sclist;
            Repeater1.DataBind();
        }
    }
}