using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Study.Training.Infrastructure.Data.Context;
using DI = Study.Training.DependencyInjection;

namespace Study.Training.Api
{
    public class Startup
    {
        private readonly IHostingEnvironment environment;
        private readonly IConfiguration configuration;
        private readonly ILoggerFactory loggerFactory;

        public Startup(IConfiguration configuration, IHostingEnvironment environment, ILoggerFactory loggerFactory)
        {
            this.environment = environment;
            this.configuration = configuration;
            this.loggerFactory = loggerFactory;
        }

        // continuar daqui: https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/startup?view=aspnetcore-2.1
        public void ConfigureServices(IServiceCollection services)
        {
            
            DI.Application.Configure(services);
            DI.Repository.Configure(services);
            DI.TaskService.Configure(services);

            services.AddMvc();
            services.AddDbContext<TrainingDbContext>((DbContextOptionsBuilder op) => op.UseSqlServer(configuration.GetConnectionString("Training")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(x => x.MapRoute(name: "default", template: "{controller = subject}/{action=get}"));
        }
    }
}
