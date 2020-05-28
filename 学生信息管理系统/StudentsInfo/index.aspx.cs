using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.StudentsInfo
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<XTGG> gglist = new GGManage().LookXTGG();
            Repeater1.DataSource = gglist;
            Repeater1.DataBind();
        }
    }
}