using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public IEnumerable<Attendance> Attendances { get; set; }

        public IEnumerable<Following> Followings { get; set; }
    }
}