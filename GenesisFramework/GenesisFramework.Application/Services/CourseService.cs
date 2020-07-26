﻿using GenesisFramework.Application.Interfaces;
using GenesisFramework.Application.ViewModels;
using GenesisFramework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { 
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
