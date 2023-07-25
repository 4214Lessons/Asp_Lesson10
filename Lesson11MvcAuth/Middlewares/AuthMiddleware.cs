using Lesson11MvcAuth.Models;
using Lesson11MvcAuth.Services;

namespace Lesson11MvcAuth.Middlewares
{
    public class AuthMiddleware
    {
        private RequestDelegate next;

        public AuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            IUserManager? userManager = context.RequestServices.GetService<IUserManager>();
            UserCredentials? userCredentials = userManager?.GetUserCredentials();
            if (userCredentials is not null)
                await next.Invoke(context);
            else
                await context.Response.WriteAsync("Unauthorized");
        }
    }
}
