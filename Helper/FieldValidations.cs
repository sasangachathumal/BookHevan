using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookHevan.Helper
{
    internal class FieldValidations
    {
        public FieldValidations() { }

        /**
         * Check if the given string is a valid email address
         * @param email: The email address to be checked
         * @return: True if the email is valid, false otherwise
         */
        public static bool isEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        /**
         * Check if the given key press event have a valid letter key code
         * @param e: key press event
         * @return: True if the key code is valid, false otherwise
         */
        public static bool isAllLetters(KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            return (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar));
        }

        /**
         * Check if the given key press event have a valid digit key code
         * @param e: key press event
         * @return: True if the key code is valid, false otherwise
         */
        public static bool isAllDigits(KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            return (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar));
        }
    }
}
