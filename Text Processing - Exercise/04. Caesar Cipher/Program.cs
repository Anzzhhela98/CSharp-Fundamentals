using System;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] encryptText = text.ToCharArray();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(encryptText);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i] += 3;
            }
            string messages = Encoding.ASCII.GetString(asciiBytes);
            Console.WriteLine(messages);

        }
    }
}
