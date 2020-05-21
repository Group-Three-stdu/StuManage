using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class GGManage
    {
        //查看系统公告
        public List<JXGG> LookJXGG(int CourseId)
        {
            return new GGService().LookJXGG(CourseId);
        }

        //发布公告
        public int fabuGG(JXGG gg)
        {
            return new GGService().fabuGG(gg);
        }

        //删除公告
        public int DelGG(int GGId)
        {
            return new GGService().DelGG(GGId);
        }
    }
}
