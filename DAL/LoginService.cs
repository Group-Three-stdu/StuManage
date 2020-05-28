using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;
namespace DAL
{

    //接收一个包含用户名密码的user ，返回一个完整的user，若账号密码不正确，就返回null
    public class LoginService
    {
        public Login UserLogin(Login user)
        {
            string sql = "Select StuName,type from Login where UserName=@UserName and PassWord=@PassWord";
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@UserName",user.UserName),
                new SqlParameter("@PassWord",user.PassWord)
            };
            SqlDataReader result = null;
            result = new Helper.SQLHelper().queryAllResult(sql, param, false);
            if (result.Read())
            {
                user.StuName = result["StuName"].ToString();
                user.type = Convert.ToInt32(result["type"]);
                return user;
            }
            return null;
        }


        public int AlterPwd(Login user)
        {
            string sql = "update Login set PassWord = @PassWord where UserName = @UserName";
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@UserName",user.UserName),
                new SqlParameter("@PassWord",user.PassWord)
            };
            int result = new Helper.SQLHelper().update(sql, param, false);
            return result;
        }
    }
}