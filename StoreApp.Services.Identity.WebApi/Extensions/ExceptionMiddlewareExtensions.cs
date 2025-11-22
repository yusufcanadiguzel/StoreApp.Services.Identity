using Microsoft.AspNetCore.Diagnostics;
using StoreApp.Services.Identity.Application.Exceptions.Abstract;
using StoreApp.Services.Identity.Application.Logging;
using StoreApp.Services.Identity.WebApi.Models;

namespace StoreApp.Services.Identity.WebApi.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureExceptionHandler(this WebApplication webApplication, ILoggerService loggerService)
    {
        webApplication.UseExceptionHandler(appError =>
            appError.Run(async context =>
            {
                context.Response.ContentType = "application/json";

                var contentFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contentFeature is not null)
                {
                    context.Response.StatusCode = contentFeature.Error switch
                    {
                        NotFoundException => StatusCodes.Status404NotFound,
                        _ => StatusCodes.Status500InternalServerError
                    };

                    loggerService.LogError($"Something went wrong: {contentFeature.Error}");

                    await context.Response.WriteAsync(new ErrorModel
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = contentFeature.Error.Message

                    }.ToString());
                }
            })
        );
    }
}
