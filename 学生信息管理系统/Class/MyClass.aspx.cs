using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.Score
{
    public partial class fudaoyuan_Score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int FDYId = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            List<Model.Class> courseList = new CourseManege().queryFDYClass(FDYId);
            DataList1.DataSource = courseList;
            DataList1.DataBind();
        }

        //查看班级
        protected void Button2_Click(object sender, EventArgs e)
        {
            string ClassId = ((Button)sender).CommandArgument.ToString();
            Response.Redirect("~/Class/ClassDetails.aspx?ClassId=" + ClassId );
        }
    }
}