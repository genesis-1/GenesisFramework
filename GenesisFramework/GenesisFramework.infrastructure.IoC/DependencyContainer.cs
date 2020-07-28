using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using GenesisFramework.Application.Interfaces;
using GenesisFramework.Application.Services;
using GenesisFramework.Domain.Interfaces;
using GenesisFramework.infrastructure.Data.Repository;
using MediatR;
using GenesisFramework.Domain.Core.Bus;
using GenesisFramework.Infrastructure.Bus;
using GenesisFramework.Domain.Commands;
using GenesisFramework.Domain.CommandHandler;
using GenesisFramework.infrastructure.Data.Context;

namespace GenesisFramework.infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemmoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            //application layer
            services.AddScoped<ICourseService,CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository,CourseRepository>();

            //Registering Datacontext
            services.AddScoped<GenesisFrameworkDbContext>();


        }
    }
}
