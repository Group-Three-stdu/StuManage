using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class TeaManage
    {
        //查询教师信息
        public Teacher queryTeainfoById(int TeaId)
        {
            return new TeaService().queryTeainfoById(TeaId);
        }

        //修改信息
        public int alterTeainfo(Teacher tea)
        {
            return new TeaService().alterTeainfo(tea);
        }
    }
}
