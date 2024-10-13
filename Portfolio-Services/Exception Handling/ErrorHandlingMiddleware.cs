using Newtonsoft.Json;
using System.Net;

namespace Portfolio_Services.Exception_Handling
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            var statusCode = (int)HttpStatusCode.InternalServerError;
            string message;
            DateTime timestamp = DateTime.Now;

            switch (ex)
            {
                case BadHttpRequestException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    message = "Invalid request.";
                    break;
                case UnauthorizedAccessException:
                    statusCode = (int)HttpStatusCode.Unauthorized;
                    message = "Unauthorized access.";
                    break;
                case AccessViolationException:
                    statusCode = (int)HttpStatusCode.Forbidden;
                    message = "Access violation.";
                    break;
                case ArgumentException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    message = ex.Message;
                    break;
                default:
                    message = "An internal server error occurred.";
                    break;
            }

            // Log the exception (e.g., using Serilog, NLog, etc.)
            Console.WriteLine($"Error: {ex.Message}");

            var errorResponse = new
            {
                dateTime = timestamp,
                status = statusCode,
                message,
                reason = ex.Message,
                httpStatusCode = (HttpStatusCode)statusCode
            };

            var jsonResponse = JsonConvert.SerializeObject(errorResponse);
            context.Response.StatusCode = statusCode;
            await  context.Response.WriteAsync(jsonResponse);
        }
    }
    

}
