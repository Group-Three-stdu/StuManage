using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 学生信息管理系统.StudentsInfo
{
    public partial class guanliyuan_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }
    }
}