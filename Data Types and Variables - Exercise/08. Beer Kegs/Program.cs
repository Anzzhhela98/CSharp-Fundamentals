using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
           byte n = byte.Parse(Console.ReadLine());
            float maxValueKeg = float.MinValue;
            string type = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float result = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if (result>maxValueKeg)
                {
                    maxValueKeg = result;
                    type = model;
                }

            }
            Console.WriteLine($"{type}");

        }
    }
}
