using Microsoft.Extensions.DependencyInjection;
using Study.Training.Service.EntityServices.Concrete;
using Study.Training.Service.EntityServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.DependencyInjection
{
    public class TaskService
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(ISubjectEntityService), typeof(SubjectEntityService));
        }
    }
}
