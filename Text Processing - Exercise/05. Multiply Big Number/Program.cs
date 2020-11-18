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

            string numbers = Console.ReadLine().TrimStart('0'); ;
            int multiplyBy = int.Parse(Console.ReadLine());
            if (multiplyBy == 0||numbers=="")
            {
                Console.WriteLine(0);
                return;
            }
          


            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int rezult = (int.Parse(numbers[i].ToString()) * multiplyBy + remainder);
                remainder = 0;
                if (rezult > 9)
                {
                    remainder = rezult / 10;
                    rezult = rezult % 10;
                }
                sb.Append(rezult);
            }
            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder finalNum = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalNum.Append(sb[i]);
            }
            Console.WriteLine(finalNum);



        }
    }
}
