using GenesisFramework.Domain.Interfaces;
using GenesisFramework.Domain.Models;
using System;
using System.Collections.Generic;
using GenesisFramework.infrastructure.Data.Context;

namespace GenesisFramework.infrastructure.Data.Repository
{
    class CourseRepository : ICourseRepository
    {
        private GenesisFrameworkDbContext _context;

        public CourseRepository(GenesisFrameworkDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
