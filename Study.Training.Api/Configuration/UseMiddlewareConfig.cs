using Microsoft.AspNetCore.Builder;
using Study.Training.Api.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.Training.Api.Configuration
{
    public static class UseMiddlewareConfiguration
    {
        public static IApplicationBuilder UseMiddlewareConfig(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ProtocolMiddleware>();
        }
    }
}
