using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = string.Empty;
            int point = 0;
            Dictionary<string, int> examFinished = new Dictionary<string, int>();
            Dictionary<string, int> submisions = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] splitted = input.Split("-");
                string userName = splitted[0];
                string language = splitted[1];
                if (splitted.Length >= 3)
                {
                    point = int.Parse(splitted[2]);
                    if (!examFinished.ContainsKey(userName))
                    {
                        examFinished.Add(userName, point);
                    }
                    else
                    {
                        if (examFinished[userName] < point)
                        {
                            examFinished[userName] = point;
                        }
                    }
                    if (!submisions.ContainsKey(language))
                    {
                        submisions.Add(language, 0);
                    }

                    submisions[language]++;

                }
                else
                {

                    examFinished.Remove(userName);
                }

            }
            Console.WriteLine($"Results:");
            foreach (var finish in examFinished.OrderByDescending(x => x.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{finish.Key} | {finish.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var exam in submisions.OrderByDescending(x => x.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{exam.Key} - {exam.Value}");

            }
        }
    }
}
