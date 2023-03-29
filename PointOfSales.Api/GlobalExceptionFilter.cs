

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PointOfSales.Application.Exceptions;
using System.Net;

namespace PointOfSales.Api;
public class GlobalExceptionFilters : IExceptionFilter
{
    private readonly ILogger _logger;


    public GlobalExceptionFilters(ILogger<GlobalExceptionFilters> logger)
    {
        _logger = logger;
    }


    public void OnException(ExceptionContext context)
    {
        if (!context.ExceptionHandled)
        {
            var exception = context.Exception;


            int statusCode;


            switch (true)
            {
                case bool _ when exception is BadRequestException:
                    statusCode = (int)HttpStatusCode.Unauthorized;
                    break;


                case bool _ when exception is ValidationException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case bool _ when exception is ArgumentException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;
                default:
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }


            _logger.LogError($"GlobalExceptionFilter: Error in {context.ActionDescriptor.DisplayName}. {exception.Message}. Stack Trace: {exception.StackTrace}");


            // Custom Exception message to be returned to the UI
            context.Result = new ObjectResult(exception.Message) { StatusCode = statusCode };
        }
    }
}