using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Service
{
    public class AuthService : IAuthService
    {

        public static List<Token> Tokens = new List<Token>();

        public Guid GetNewToken()
        {
            var token = new Token();
            Tokens.Add(token);
            return token.token;
        }

        public bool ValidateToken(Guid token) => Tokens.Any(x => x.token == token);

    }
}
