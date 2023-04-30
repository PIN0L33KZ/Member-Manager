using System;
using System.Security.Cryptography;
using System.Text;

namespace Member_Manager
{
    internal class Security
    {
        public static string HashString(string str)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(str);
            byte[] hashedBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                hashedBytes = sha256.ComputeHash(inputBytes);
            }

            string hashedString = BitConverter.ToString(hashedBytes).Replace("-", "");

            return hashedString;
        }
    }
}