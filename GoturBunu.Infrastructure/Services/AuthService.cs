using AutoMapper;
using GoturBunu.Application.Features.Auth;
using GoturBunu.Application.Services;
using GoturBunu.Domain.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace GoturBunu.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IJwtUtils _jwtUtils;
        private readonly IClaimUtils _claimUtils;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, RoleManager<Role> roleManager, IHttpContextAccessor httpContextAccessor, IJwtUtils jwtUtils, IClaimUtils claimUtils)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
            _jwtUtils = jwtUtils;
            _claimUtils = claimUtils;
        }

        public async Task<LoginResultDto> Login(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return new LoginResultDto { Succeeded = false };
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, password, true);
            if (!result.Succeeded)
            {
                return new LoginResultDto { Succeeded = false };
            }

            var token = _jwtUtils.GenerateJwt(user);
            var claims = await _claimUtils.GetUserClaims(user);
            return new LoginResultDto
            {
                Succeeded = true,
                Token = token,
                User = _mapper.Map<UserDto>(user),
                Roles = await _userManager.GetRolesAsync(user),
                Permissions = claims.Select(c => c.Value.ToString()).ToList()
            };
        }

        public async Task<LoginResultDto> LoginWithToken()
        {
            var emailClaim = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            if (emailClaim == null) { return new LoginResultDto { Succeeded = false }; }

            var user = await _userManager.FindByEmailAsync(emailClaim.Value);
            if (user == null) { return new LoginResultDto { Succeeded = false }; }

            var token = _jwtUtils.GenerateJwt(user);
            var claims = await _claimUtils.GetUserClaims(user);
            return new LoginResultDto
            {
                Succeeded = true,
                Token = token,
                User = _mapper.Map<UserDto>(user),
                Roles = await _userManager.GetRolesAsync(user),
                Permissions = claims.Select(c => c.Value.ToString()).ToList()
            };
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> Register(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }
    }
}
