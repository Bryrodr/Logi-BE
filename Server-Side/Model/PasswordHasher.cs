using Server_Side.Interface;
using System.Security.Cryptography;

namespace Server_Side.Model
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            var hash = SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }
        public bool VerifyHashedPassword(string hashedPassword, string password)
        {
            return hashedPassword == HashPassword(password);
        }
    }
}
