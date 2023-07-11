using System;
using System.Text;
using System.Security.Cryptography;

namespace HashConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainData = "Rohan";
            Console.WriteLine("Raw data: {0}", plainData);
            string hashedData = ComputeSha256Hash(plainData);  //converting it into hashcode
            Console.WriteLine("Hash {0}", hashedData);
            Console.WriteLine(ComputeSha256Hash("Rohan"));
            Console.ReadLine();        
        }

        static string ComputeSha256Hash(string rawData)
        {            
            using (SHA256 sha256Hash = SHA256.Create()) //Secure Hash Algorithm 256 - bit
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));                

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}