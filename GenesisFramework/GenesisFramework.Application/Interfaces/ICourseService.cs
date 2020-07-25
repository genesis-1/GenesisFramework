﻿using GenesisFramework.Application.ViewModels;
using GenesisFramework.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
