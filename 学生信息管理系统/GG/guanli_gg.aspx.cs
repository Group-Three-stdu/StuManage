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
    public partial class guanli_gg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<XTGG> gglist = new GGManage().LookXTGG();
            Repeater1.DataSource = gglist;
            Repeater1.DataBind();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            int GGId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            int result = new GGManage().DelXTGG(GGId);
            if (result > 0)
                Response.Write("<script>window.alert('公告已删除！');</script>");
            else
                Response.Write("<script>window.alert('删除失败！');</script>");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int GGId = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            Response.Redirect("~/GG/GGDetail.aspx/?GGId=" + GGId);
        }
    }
}