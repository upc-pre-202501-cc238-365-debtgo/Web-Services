using DebtGo.IAM.Application.Internal.OutBoundServices;
using BCryptNet = BCrypt.Net.BCrypt;

namespace DebtGo.IAM.Infrastructure.Hashing.BCrypt.Services
{
    public class HashingService : IHashingService
    {
        public string GenerateHash(string password)
        {
            return BCryptNet.HashPassword(password);
        }

        public bool VerifyHash(string password, string hash)
        {
            return BCryptNet.Verify(password, hash);
        }
    }
}