
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;


namespace Ecommerce.WebAPI.Exceptions
{
    public class AppExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext, 
            Exception exception, 
            CancellationToken cancellationToken)
        {
            var response = new ErrorResponse()
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Title = "Something went wrong",
                Message = exception.Message
            };
            
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

            return true;
        }
    }
}
