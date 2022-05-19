using System;
using System.Security.Cryptography;
using System.Text;

namespace Lesson2
{
    class Task1
    {
        static void Main()
        {
            const string login = "Sofya";
            const string passwordHash = "938D34FFA2846893EDC65227A8EC5B0C9F8CC39E31D5B61CD65DF697248B925B"; // password = "somepassword123"

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("For sign in add your credentials.");
                Console.Write("Login: ");
                string userLogin = Console.ReadLine();
                Console.Write("Password: ");

                string userPassword = Console.ReadLine();
                SHA256 sha256Hash = SHA256.Create();
                byte[] userPasswordBytes = Encoding.UTF8.GetBytes(userPassword);
                byte[] userPasswordHashBytes = sha256Hash.ComputeHash(userPasswordBytes);
                string userHash = BitConverter.ToString(userPasswordHashBytes).Replace("-", String.Empty);

                if (userLogin == login && userHash == passwordHash)
                {
                    Console.WriteLine("You are let in the system.");
                    return;
                }
            }
            Console.WriteLine("Error: credentials are not correct. Access denied.");
        }
    }
}
