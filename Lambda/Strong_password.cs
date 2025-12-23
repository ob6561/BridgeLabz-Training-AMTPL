using System;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Strong_password
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine() ?? "";

            
            Func<string, bool> func = pwd =>
            {
                if (string.IsNullOrEmpty(pwd))
                    return false;

                bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

                foreach (char c in pwd)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    else if (char.IsLower(c)) hasLower = true;
                    else if (char.IsDigit(c)) hasDigit = true;
                    else if (!char.IsLetterOrDigit(c)) hasSpecial = true;
                }

                
                return pwd.Length >= 8 && hasUpper && hasLower && hasDigit && hasSpecial;
            };

            bool isStrong = func(password);

            if (isStrong)
                Console.WriteLine("Password is strong.");
            else
                Console.WriteLine("Password is NOT strong. A strong password should be at least 8 characters and include uppercase, lowercase, digit and a special character.");

            Console.ReadLine(); 
        }
    }
}
