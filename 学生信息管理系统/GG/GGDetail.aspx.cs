using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.GG
{
    public partial class GGDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int GGId = Convert.ToInt32(Request.Params["GGId"]);
            XTGG gg = new GGManage().queryDetail(GGId);
            GGHead.Text = gg.GGHead.ToString();
            GGcontent.Text = gg.GGcontent.ToString();
            Time.Text = gg.GGdateTime.ToString("yyyy-MM-dd HH-mm-ss");
            author.Text = gg.GGauthor.ToString();
        }
    }
}