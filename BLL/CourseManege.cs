using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class CourseManege
    {
        public int DeleteSelectedCouser(string CourseId,string Selected_courseid)
        {
            int result = new CourseService().queryCouresProperty(CourseId);
            if (result == 0)
                return -1;
            return new CourseService().deleteSelectedCourse(Selected_courseid);
        }
    }
}
