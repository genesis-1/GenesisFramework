using GenesisFramework.Application.Interfaces;
using GenesisFramework.Application.ViewModels;
using GenesisFramework.Domain.Commands;
using GenesisFramework.Domain.Core.Bus;
using GenesisFramework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );
            _bus.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { 
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
