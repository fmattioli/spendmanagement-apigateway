﻿using Serilog;
using Serilog.Exceptions;
using Serilog.Formatting.Json;
namespace SpendManagement.Receipts.Api.Extensions
{
    public static class LogExtension
    {
        public static IServiceCollection AddLoggingDependency(this IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithExceptionDetails()
                .WriteTo.Console(new JsonFormatter())
                .CreateLogger();

            return services.AddSingleton(Log.Logger);
        }
    }
}
