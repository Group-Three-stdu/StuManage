using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 学生信息管理系统.homework
{
    public partial class zuoye_tijiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string mysql, c_time, c_content;            
           // int c_sffb = 1;
            //c_time = TextBox2.Text;
            //c_content = editor1.Value;
           // mysql = "insert into Answer_Stu( Answer, time, ) values(N'" +  "',N'" + c_content + "','" + c_time + "','"  + "')";
           
    
            Response.Write("<script>window.alert('作业已提交！');</script>");
        }
    }
}
    
