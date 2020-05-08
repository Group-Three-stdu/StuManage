using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统
{
    public partial class Login : System.Web.UI.Page
    {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
            //封装实体对象
            //封装实体对象
            int UserName = Convert.ToInt32(Request.Form["txt_username"]);
            string PassWord = Request.Form["txt_password"].ToString();
            Model.Login user = new Model.Login()
            {
                UserName = UserName,
                PassWord = PassWord
            };
            //调用BLL层方法,返回一个新的user对象
            user = new LoginManage().LoginService(user);

            //根据返回的数据进行操作
            if (user == null)
                Literal1.Text = "<script type='text/javascript'>alert('账号密码错误')</script>";
            else
            {
                Session["CurrentUser"] = user;
                if (user.type == 1)
                    Literal1.Text = "<script type='text/javascript'>alert('登陆成功');location.href='StudentsInfo/stu_index.aspx'</script>";
                if (user.type == 2)
                    Literal1.Text = "<script type='text/javascript'>alert('登陆成功');location.href='StudentsInfo/xueshengchu_index.aspx'</script>";
                if (user.type == 3)
                    Literal1.Text = "<script type='text/javascript'>alert('登陆成功');location.href='StudentsInfo/jiaowuchu_index.aspx'</script>";
                if (user.type == 4)
                    Literal1.Text = "<script type='text/javascript'>alert('登陆成功');location.href='StudentsInfo/teacher_index.aspx'</script>";
            }



        }
    }

}