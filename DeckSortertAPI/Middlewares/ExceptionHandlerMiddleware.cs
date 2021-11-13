using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckSortertAPI.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
    

        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context).ConfigureAwait(false);
            }
            catch (ArgumentException e)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsync(e.Message).ConfigureAwait(false);
            }
        }

    }

    public static class ExceptionHandlerMiddlewareExtension
    {

        public static IApplicationBuilder UseDeckSorterExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }

    }
}
