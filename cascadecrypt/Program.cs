using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace cascadecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string hackit = "c4scadek3y654321";
            string encrypted = "BQO5l5Kj9MdErXx6Q6AGOw==";
            string password = decrypt(encrypted, hackit);
            Console.Write(password);
            Console.ReadLine();
        }
        public static string lmao = "1tdyjCbY1Ix49842";
        public static string decrypt(string encrypted, string key)
        {
            byte[] array = Convert.FromBase64String(encrypted);
            Aes aes = Aes.Create();
            aes.KeySize = 128;
            aes.BlockSize = 128;
            aes.IV = Encoding.UTF8.GetBytes(lmao);
            aes.Mode = CipherMode.CBC;
            aes.Key = Encoding.UTF8.GetBytes(key);
            string strr;
            using (MemoryStream mStream = new MemoryStream(array))
            {
                using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] array2 = new byte[checked(array.Length - 1 + 1)];
                    cStream.Read(array2, 0, array2.Length);
                    strr = Encoding.UTF8.GetString(array2);
                }
            }
            return strr;
        }
    }
}
