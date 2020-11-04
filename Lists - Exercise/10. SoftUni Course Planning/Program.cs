using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> scheduleLes = Console
                      .ReadLine()
                      .Split(",", StringSplitOptions.RemoveEmptyEntries)
                      .ToList();
            string[] command = Console.ReadLine().Split(':');


            while (command[0] != "course start")
            {
                switch (command[0])
                {
                    case "Add":
                        if (!scheduleLes.Contains(command[1]) )
                        {
                            scheduleLes.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        if (!scheduleLes.Contains(command[1]))
                        {
                            int index = int.Parse(command[2]);
                            scheduleLes.Insert(index, command[1]);
                        }
                        break;
                    case "Remove": 
                        if (scheduleLes.Contains(command[1]))
                        {
                            scheduleLes.Remove(command[1]);
                            scheduleLes.Remove($"{command[1]}-Exercise");
                        }
                        break;
                    case "Swap":
                        if (scheduleLes.Contains(command[1]) && scheduleLes.Contains(command[2]))
                        {
                            int firstLessonPosition = scheduleLes.IndexOf(command[1]);
                            int secondLessonPosition = scheduleLes.IndexOf(command[2]);

                            scheduleLes[firstLessonPosition] = command[2];
                            scheduleLes[secondLessonPosition] = command[1];
                            if (scheduleLes.Contains(command[1] + "-" + "Exercise"))
                            {
                                scheduleLes.Remove(command[1] + "-" + "Exercise");

                                if (int.Parse(command[1]) == scheduleLes.Count - 1)
                                {
                                    scheduleLes.Add(command[1] + "-" + "Exercise");
                                }
                                else
                                {
                                    scheduleLes.Insert(int.Parse(command[1]) + 1, command[1] + "-" + "Exercise");
                                }
                            }
                            if (scheduleLes.Contains(command[2] + "-" + "Exercise"))
                            {
                                scheduleLes.Remove(command[2] + "-" + "Exercise");

                                if (int.Parse(command[2]) == scheduleLes.Count - 1)
                                {
                                    scheduleLes.Add(command[2] + "-" + "Exercise");
                                }
                                else
                                {
                                    scheduleLes.Insert(int.Parse(command[2]) + 1, command[2] + "-" + "Exercise");
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        if (scheduleLes.Contains(command[1]))
                        {
                            if (!scheduleLes.Contains(command[1] + "-" + "Exercise"))
                            {
                                int lessonIndex = 0;

                                for (int i = 0; i < scheduleLes.Count; i++)
                                {
                                    if (scheduleLes[i] == command[1])
                                    {
                                        lessonIndex = i;
                                    }
                                }
                                scheduleLes.Insert(lessonIndex + 1, command[1] + "-" + "Exercise");
                            }
                        }
                        else
                        {
                            scheduleLes.Add(command[1]);
                            scheduleLes.Add(command[1] + "-" + "Exercise");
                        }
                        break;
                }
                command = Console.ReadLine().Split(':');
            }
            for (int i = 0; i < scheduleLes.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduleLes[i]}");
            }
        }
    }
}
