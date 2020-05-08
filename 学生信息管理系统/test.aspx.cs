using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 学生信息管理系统
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList1.DataTextField = "caoyaning";
            //DropDownList1.DataValueField = "1";
            string name = Request.Form["DropDownList1"];
            Response.Write(name);
        }
    }
}