using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> statistic = new Dictionary<string, Dictionary<string, int>>();
            string position;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] splitted = input
                    .Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firtsPlayer = splitted[0];
                if (splitted.Length > 2)
                {
                    position = splitted[1];
                    int skill = int.Parse(splitted[2]);
                    if (!statistic.ContainsKey(firtsPlayer))
                    {
                        statistic.Add(firtsPlayer, new Dictionary<string, int>());
                        statistic[firtsPlayer][position] = skill;
                    }
                    else
                    {
                        // проверяваме дали въведената инф e със същия играч и позиция
                        if (statistic[firtsPlayer].ContainsKey(position))
                        {
                            if (statistic[firtsPlayer][position] < skill)
                            {

                                statistic[firtsPlayer][position] = skill;
                            }
                            // ако е по добра по точки я сменяме
                        }
                        else
                        {
                            // добавяме новата инф., точки за играча
                            statistic[firtsPlayer].Add(position, skill);
                        }
                    }
                }
                else
                {
                    string secPlayer = splitted[1];
                    if (statistic.ContainsKey(firtsPlayer) && statistic.ContainsKey(secPlayer))
                    {
                        foreach (var item in statistic[firtsPlayer])
                        {
                            if (statistic[secPlayer].ContainsKey(item.Key))
                            {
                                if (statistic[secPlayer][item.Key] < statistic[firtsPlayer][item.Key])
                                {
                                    statistic.Remove(secPlayer);
                                    break;
                                }
                                else if (statistic[secPlayer][item.Key] > statistic[firtsPlayer][item.Key])
                                {
                                    statistic.Remove(firtsPlayer);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> playerFinalSkills = new Dictionary<string, int>();
            foreach (var player in statistic)
            {
                playerFinalSkills.Add(player.Key, player.Value.Sum(x => x.Value));
            }
            foreach (var kvp in playerFinalSkills.OrderByDescending(x=>x.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");
                foreach (var player in statistic[kvp.Key]
                    .OrderByDescending(s=>s.Value).ThenBy(p=>p.Key))
                {
                    Console.WriteLine($"- {player.Key} <::> {player.Value}");
                }
            }
        }
    }
}
