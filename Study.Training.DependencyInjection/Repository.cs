using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Study.Training.Infrastructure.Data.Concrete;
using Study.Training.Infrastructure.Data.Context;
using Study.Training.Infrastructure.Data.Interface;
using System;

namespace Study.Training.DependencyInjection
{
    public class Repository
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ISubjectRepository), typeof(SubjectRepository));
        }
    }
}
