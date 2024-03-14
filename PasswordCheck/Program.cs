using System;
using System.Security.Authentication;

namespace PasswordCheck
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-~+";
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            Console.WriteLine(password);
            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);

            switch(score)
            {
                case 4:
                    case 5:
                    Console.WriteLine("Extremely Strong");
                    break;
                case 3:
                    Console.WriteLine("Strong");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 1:
                    Console.WriteLine("Weak");
                    break;
                default:
                    Console.WriteLine("Does not meet requirements.");
                    break;
            }
        }
    }
}