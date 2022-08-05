using Takever.Domain;

namespace Takever.Service.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
