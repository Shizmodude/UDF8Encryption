using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SteveHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string password, username, EncrypPass;

            Console.WriteLine("Please Enter a Username");
            username = Console.ReadLine();
            Console.WriteLine("Please Enter a Password");
            password = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("PLease enter a password");
            }
            else
            {
                EncrypPass= Encrypt(password);
                Console.WriteLine("Encrypted Password: " + EncrypPass);
            }

            Console.ReadLine();

        }

        static String Encrypt(String password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }
    }
}
