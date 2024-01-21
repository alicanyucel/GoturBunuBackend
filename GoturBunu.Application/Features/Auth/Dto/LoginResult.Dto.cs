
namespace GoturBunu.Application.Features.Auth
{
    public class LoginResultDto
    {
        public bool Succeeded { get; set; }
        public string? Token { get; set; }
        public UserDto? User { get; set; }
        public IList<string>? Roles { get; set; }
        public List<string>? Permissions { get; set; }
    }
}
