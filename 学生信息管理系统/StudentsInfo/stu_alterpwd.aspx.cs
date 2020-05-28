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
    public partial class stu_alterpwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_alterpass_Click(object sender, EventArgs e)
        {
            string oldPassWord = txt_pwd.Text.Trim();
            string newPassWord = txt_newpwd.Text.Trim();
            string newPassWord2 = txt_renewpwd.Text.Trim();
            if(newPassWord!= newPassWord2)
            {
                Response.Write("<script type='text/javascript'>alert('两次输入的密码不一致')</script>");
                return;
            }
            int UserName = Convert.ToInt32(((Model.Login)Session["CurrentUser"]).UserName);
            Model.Login user = new Model.Login()
            {
                UserName = UserName,
                PassWord = oldPassWord
            };
            user = new LoginManage().LoginService(user);
            if (user == null)
            {
                Response.Write("<script type='text/javascript'>alert('原密码错误')</script>");
                return;
            }
            Model.Login newuser = new Model.Login()
            {
                UserName = UserName,
                PassWord = newPassWord
            };
            int res = new LoginManage().AlterPwd(newuser);
            if(res>0)
                Response.Write("<script type='text/javascript'>alert('更新成功');</script>");
            else
                Response.Write("<script type='text/javascript'>alert('更新失败')</script>");
        }
    }
}