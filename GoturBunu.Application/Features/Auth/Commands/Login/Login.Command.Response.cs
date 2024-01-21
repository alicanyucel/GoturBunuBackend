namespace GoturBunu.Application.Features.Auth
{
    public sealed record class LoginCommandResponse(string? AccessToken, UserDto? User, IList<string>? Roles, List<string>? Permissions);
}
