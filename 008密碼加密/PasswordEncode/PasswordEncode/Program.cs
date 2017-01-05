using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEncode
{
    class Program
    {
        private static string PasswordSalt = "1qaz";

        static void Main(string[] args)
        {
            Console.Write("Input Password: ");
            string password = Console.ReadLine();

            string encode = CryptographyPassword(password, Program.PasswordSalt);

            Console.WriteLine(encode);

            Console.Write("Finish!");
            Console.ReadLine();
        }

        public static string CryptographyPassword(string password, string salt)
        {
            string cryptographyPassword =
                System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password + salt, "sha1");

            return cryptographyPassword;
        }

    }
}
