
using Microsoft.AspNetCore.Diagnostics;


namespace Ecommerce.WebAPI.Exceptions
{
    public class AppExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse()
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Title = "Something went wrong",
                Message = exception.Message
            };

            await httpContext.Response.WriteAsJsonAsync("Something went wrong");
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return true;
        }
    }
}
