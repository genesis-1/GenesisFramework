using GenesisFramework.Domain.Commands;
using GenesisFramework.Domain.Interfaces;
using GenesisFramework.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenesisFramework.Domain.CommandHandler
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImgeUrl = request.ImageUrl
            };

            _courseRepository.add(course);

            return Task.FromResult(true);
        }
    }
}
