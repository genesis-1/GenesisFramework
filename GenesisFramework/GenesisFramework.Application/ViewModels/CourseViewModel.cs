using GenesisFramework.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
