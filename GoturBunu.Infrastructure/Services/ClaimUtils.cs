using GoturBunu.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace GoturBunu.Infrastructure.Services
{
    public interface IClaimUtils
    {
        public Task<IList<Claim>> GetUserClaims(User user);
    }

    public class ClaimUtils : IClaimUtils
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public ClaimUtils(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task<IList<Claim>> GetUserClaims(User user)
        {
            // fetch user claims first.
            var userClaims = await _userManager.GetClaimsAsync(user);

            // add role claims to user claims.
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var roleName in userRoles)
            {
                var role = await _roleManager.FindByNameAsync(roleName);
                var roleClaims = await _roleManager.GetClaimsAsync(role);

                foreach (var claim in roleClaims)
                {
                    userClaims.Add(claim);
                }
            }

            return userClaims;
        }
    }
}
