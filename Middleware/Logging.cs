using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CoreAPI.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Logging
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public Logging(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<Logging>();
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            finally
            {
                _logger.LogInformation("Request Logged for {method} {url} => {statuscode}", httpContext.Request?.Method, httpContext.Request?.Path, httpContext.Response.StatusCode);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoggingExtensions
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Logging>();
        }
    }
}
