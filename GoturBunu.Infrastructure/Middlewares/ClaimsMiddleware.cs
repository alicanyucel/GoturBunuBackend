using GoturBunu.Domain.Entities.Identity;
using GoturBunu.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace GoturBunu.Infrastructure.Middlewares
{
    public class ClaimsMiddleware
    {
        private readonly RequestDelegate _next;

        public ClaimsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, UserManager<User> userManager, IClaimUtils claimUtils)
        {
            if (context.User.Identity == null || !context.User.Identity.IsAuthenticated)
            {
                await _next(context);
                return;
            }

            var email = context.User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
            if (email == null)
            {
                await _next(context);
                return;
            }

            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                await _next(context);
                return;
            }

            var userClaims = await claimUtils.GetUserClaims(user);

            // concat with claims came from jwt.
            // append user id.
            var finalClaims = context.User.Claims
                .Concat(userClaims)
                .Append(new Claim(Application.Security.ClaimTypes.Id, user.Id));


            // set context user with new claims.
            context.User = new ClaimsPrincipal(new ClaimsIdentity(finalClaims, "Bearer"));

            // next.
            await _next(context);
        }
    }
}
