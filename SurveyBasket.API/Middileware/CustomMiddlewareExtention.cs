namespace SurveyBasket.API.Middileware
{
    public static class CustomMiddlewareExtention
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
           return builder.UseMiddleware<CustomMidelware>();
        }
    }
}
