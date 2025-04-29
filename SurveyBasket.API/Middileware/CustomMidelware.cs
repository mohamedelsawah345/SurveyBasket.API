using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace SurveyBasket.API.Middileware
{
     public class CustomMidelware
    {
        private readonly ILogger<CustomMidelware> _logger;
        private readonly RequestDelegate _next;


        public CustomMidelware(ILogger<CustomMidelware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context/*,RequestDelegate next*/)
        {
            _logger.LogWarning("Custom MidelWare");

             await _next(context);
            _logger.LogWarning("Proccessing responce");
        }


        //static public IApplicationBuilder UseCustomMidelware(this IApplicationBuilder builder)
        //{
        //    builder.Use(async (context, next) =>
        //    {
        //        _logger.LogWarning("Custom MidelWare");
        //    });
        //}
    }
}
