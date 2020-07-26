using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using GenesisFramework.Application.Interfaces;
using GenesisFramework.Application.Services;
using GenesisFramework.Domain.Interfaces;
using GenesisFramework.infrastructure.Data.Repository;

namespace GenesisFramework.infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application layer
            services.AddScoped<ICourseService,CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository,CourseRepository>();
        }
    }
}
