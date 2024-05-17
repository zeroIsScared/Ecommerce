namespace Ecommerce.WebAPI.Middleware
{
    public class RequestTimingMiddleware
    {
        private readonly ILogger<RequestTimingMiddleware> _logger;
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(ILogger<RequestTimingMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext ctx)
        {
            var start = DateTimeOffset.UtcNow;
            await _next.Invoke(ctx);
            _logger.LogInformation($"Request{ctx.Request.Path}: {(DateTimeOffset.UtcNow - start).TotalMilliseconds}");
        }        
    }

    public static class TimingExtentions
    {
        public static IApplicationBuilder UseTiming(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequestTimingMiddleware>();
        }
    }
}
