using OptimaDesk.Common.Models;
using OptimaDesk.Domain.Users;

namespace OptimaDesk.Application.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateUserToken(AppUser user);
        Task<AuthToken> GenerateAccessToken(AppUser user);

        Task<LoginDetails> DecodeRefreshToken(string refreshToken);
        Task<RefreshToken> GenerateRefreshToken(string userName, string password);

    }
}
