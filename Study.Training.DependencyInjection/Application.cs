using Microsoft.Extensions.DependencyInjection;
using Study.Training.Application.ApplicationServices.Concrete;
using Study.Training.Application.ApplicationServices.Interface;
using Study.Training.Service.EntityServices.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.DependencyInjection
{
    public class Application
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(ISubjectApplication), typeof(SubjectApplication));
        }
    }
}
