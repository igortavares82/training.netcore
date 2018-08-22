using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.Training.Api.Middlewares
{
    public class ProtocolMiddleware : IMiddleware
    {
        private readonly RequestDelegate next;

        public ProtocolMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var a = context.Request;

            await this.next(context);
        }
    }
}
