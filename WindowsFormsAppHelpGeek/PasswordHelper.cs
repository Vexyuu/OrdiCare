using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsAppOrdiCare
{
    public static class PasswordHelper
    {
        // Fonction pour générer un sel unique
        public static string GenerateSalt(int size = 16)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[size];
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt); // Convertir en string pour stocker en BDD
            }
        }

        // Fonction pour hasher le mot de passe avec un sel
        public static string HashPasswordWithSalt(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
