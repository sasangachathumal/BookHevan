using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BookHevan.Helper
{
    internal class PasswordSecurity
    {
        /**
         * Hash password using BCrypt
         * @param password
         * @return hashed password
         */
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /**
         * Verify password using BCrypt
         * @param password
         * @param hashedPassword
         * @return true if password is correct, false otherwise
         */
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
