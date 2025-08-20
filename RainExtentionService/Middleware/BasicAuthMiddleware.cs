using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RainExtentionService.Middleware
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public BasicAuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var username = _configuration["Authentication:Basic:Username"];
            var password = _configuration["Authentication:Basic:Password"];

            var authHeader = context.Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Response.Headers["WWW-Authenticate"] = "Basic";
                await context.Response.WriteAsync("Authorization header missing or invalid.");
                return;
            }

            try
            {
                var encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                var decodedUsernamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedUsernamePassword));
                var parts = decodedUsernamePassword.Split(':', 2);

                if (parts.Length != 2 || parts[0] != username || parts[1] != password)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    context.Response.Headers["WWW-Authenticate"] = "Basic";
                    await context.Response.WriteAsync("Invalid username or password.");
                    return;
                }
            }
            catch
            {
                // در صورت بروز خطا در دیکد کردن
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Response.Headers["WWW-Authenticate"] = "Basic";
                await context.Response.WriteAsync("Invalid Authorization header.");
                return;
            }

            await _next(context);
        }
    }
}
