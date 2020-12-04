using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> allTeam = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console
                         .ReadLine()
                         .Split("-")
                         .ToArray();
                string creator = input[0];
                string name = input[1];

                Team existing = allTeam.Find(x => x.Name == name);
                if (existing != null)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue;
                }
                Team creatorExist = allTeam.Find(x => x.Creator == creator);
                if (creatorExist != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Team firtTeam = new Team(input[0], input[1]);
                allTeam.Add(firtTeam);
                Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
            }

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] input = command
                                        .Split("->")
                                        .ToArray();
                string member = input[0];
                string name = input[1];
                Team existentTeam = allTeam.Find(x => x.Name == name);
                Team existentMember = allTeam.Find(x => x.Members.Contains(member) || x.Creator == member);
                if (existentTeam == null)
                {
                    Console.WriteLine($"Team {name} does not exist!");
                    continue;
                }
                if (existentMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {name}!");
                    continue;
                }
                existentTeam.Members.Add(member);
                existentTeam.Members.Count();

            }
            List<string> allDisbandedTeams = allTeam
                .Where(a => a.Members.Count == 0)
                .OrderBy(n => n.Name)
                .Select(t=>t.Name)
                .ToList();
            allTeam.RemoveAll(t => t.Members.Count == 0);

            allTeam = allTeam
                .OrderByDescending(n => n.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            foreach (Team t in allTeam)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("Teams to disband: ");
            foreach (var t in allDisbandedTeams)
            {
                Console.WriteLine(t.ToString());
            }
        }
        class Team
        {
            public string Creator { get; set; }
            public string Name { get; set; }
            public List<string> Members { get; set; }
            public Team(string creator, string team)
            {
                Creator = creator;
                Name = team;
                this.Members = new List<string>();
            }
            public override string ToString()
            {
                List<string> sortedMembers = this.Members.OrderBy(a => a).ToList();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.Name}");
                sb.AppendLine($"- {this.Creator}");

                foreach (var mem in sortedMembers)
                {
                    sb.AppendLine($"-- {mem}");
                }
                return sb.ToString().Trim();
            }
        }
    }
}
