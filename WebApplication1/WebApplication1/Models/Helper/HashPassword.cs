using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication1.Models.Helper
{
    public class HashPassword
    {
        public static string HashPasswordCreate(string password)
        {
            using(var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hash;
            }
        }
    }
}
