using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Study.Training.Infrastructure.Data.Context;

namespace Study.Training.Api
{
    public class Startup
    {
        private readonly IHostingEnvironment env;
        private readonly IConfiguration configuration;
        private readonly ILoggerFactory loggerFactory;

        public Startup(IConfiguration configuration, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            this.env = env;
            this.configuration = configuration;
            this.loggerFactory = loggerFactory;
        }

        // continuar daqui: https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/startup?view=aspnetcore-2.1
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<TrainingDbContext>(x => x.)
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {
            }

            app.UseMvc();
        }
    }
}
