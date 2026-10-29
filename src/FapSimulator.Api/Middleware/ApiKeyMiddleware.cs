using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FapSimulator.Api.Middleware;

public sealed class ApiKeyMiddleware(
    RequestDelegate next,
    IConfiguration configuration,
    ILogger<ApiKeyMiddleware> logger)
{
    private const string HeaderName = "X-Api-Key";

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Path.StartsWithSegments("/api/v1/students"))
        {
            await next(context);
            return;
        }

        var configuredKey = configuration["Fap:ApiKey"];
        if (string.IsNullOrWhiteSpace(configuredKey))
        {
            logger.LogError("FAP Simulator API key is not configured.");
            await WriteProblemAsync(
                context,
                StatusCodes.Status500InternalServerError,
                "FAP Simulator is not configured.");
            return;
        }

        var suppliedKey = context.Request.Headers[HeaderName].ToString();
        if (!Matches(configuredKey, suppliedKey))
        {
            await WriteProblemAsync(
                context,
                StatusCodes.Status401Unauthorized,
                "A valid API key is required.");
            return;
        }

        await next(context);
    }

    private static bool Matches(string configuredKey, string suppliedKey)
    {
        var expected = Encoding.UTF8.GetBytes(configuredKey);
        var actual = Encoding.UTF8.GetBytes(suppliedKey);
        return expected.Length == actual.Length &&
               CryptographicOperations.FixedTimeEquals(expected, actual);
    }

    private static async Task WriteProblemAsync(HttpContext context, int statusCode, string title)
    {
        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsJsonAsync(new ProblemDetails
        {
            Status = statusCode,
            Title = title,
        });
    }
}
