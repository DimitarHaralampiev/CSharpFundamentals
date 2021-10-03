using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem12
{

    public class Team
    {

        public Team()
        {
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] teamData = Console.ReadLine()
                    .Split("-");

                string creator = teamData[0];
                string teamName = teamData[1];

                Team existingTeam = GetTeamByName(teams, teamName);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (CreatorExist(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team()
                {
                    Creator = creator,
                    Name = teamName
                };

                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of assignment")
                {
                    break;
                }

                string[] parts = line.Split("->");
                string user = parts[0];
                string team = parts[1];

                Team existingTeam = GetTeamByName(teams, team);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }

                existingTeam.Members.Add(user);
            }

            List<Team> sorted = teams
                .OrderByDescending(t => t.Members.Count)
                .ThenByDescending(t => t.Name)
                .ToList();

            foreach (var item in sorted)
            {

                if (item.Members.Count == 0)
                {
                    break;
                }

                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.Creator}");

                List<string> sortedMembers = item.Members
                    .OrderBy(m => m)
                    .ToList();

                foreach (var members in sortedMembers)
                {
                    Console.WriteLine($"-- {members}");
                }
            }

            List<Team> teams1 = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (var item in teams1)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static Team GetTeamByName(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    return team;
                }
            }

            return null;
        }

        private static bool IsMember(string user, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }

                foreach (var item in team.Members)
                {
                    if (user == item)
                    {
                        return true;
                    }
                }
            }

            return false;

            
        }

        private static bool CreatorExist(List<Team> teams, string creator)
        {
            foreach (var team in teams)
            {
                if (team.Creator == creator)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
