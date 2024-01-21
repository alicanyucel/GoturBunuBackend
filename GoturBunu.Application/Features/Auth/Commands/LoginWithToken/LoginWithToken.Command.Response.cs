namespace GoturBunu.Application.Features.Auth
{
    public sealed record class LoginWithTokenCommandResponse(string? AccessToken, UserDto? User, IList<string>? Roles, List<string>? Permissions);
}
