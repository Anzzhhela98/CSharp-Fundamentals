using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> users = Console
                         .ReadLine()
                         .Split(", ")
                         .ToList();
            StringBuilder rezult = new StringBuilder();
            for (int i = 0; i < users.Count; i++)
            {
                bool isCorrect = false;
                if (users[i].Length > 3 && users[i].Length <= 16)
                {
                    string userName = users[i];
                    for (int k = 0; k < userName.Length; k++)
                    {
                        if (char.IsLetterOrDigit(userName[k]) || userName[k] == '-' || userName[k] == '_')
                        {
                            isCorrect = true;
                        }
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                }
                if (isCorrect)
                {
                    rezult.AppendLine(users[i]);
                }
            }
            Console.Write(rezult);
        }
    }
}
