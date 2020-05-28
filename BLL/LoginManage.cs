using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class LoginManage
    {
        public Login LoginService(Login user)
        {
            //调用DAL层的LoginService（）方法
            return new LoginService().UserLogin(user);
        }

        public int AlterPwd(Login user)
        {
            return new LoginService().AlterPwd(user);
        }
    }
}
