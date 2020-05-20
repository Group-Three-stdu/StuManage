using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BLL;

namespace 学生信息管理系统.Handler
{
    /// <summary>
    /// setRatio 的摘要说明
    /// </summary>
    public class setRatio : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            float matchratio = float.Parse(context.Request.Params["matchratio"]);
            float classratio = float.Parse(context.Request.Params["classratio"]);
            int CourseId = Convert.ToInt32(context.Request.Params["CourseId"]);
            int result = new CourseManege().AddRatio(CourseId, matchratio, classratio);
            if (result == 1)
                context.Response.Write(1);
            else
                context.Response.Write(0);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}