using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Teamwork_projects
{
    class Program
    {
        static void Main()
        {
            // Problem:
            // It's time for teamwork projects and you are responsible for making the teams. First you will receive an integer - the count of the teams you will have to register.
            // You will be given a user and a team (separated with “-”). 
            // The user is the creator of that team.
            // For every newly created team you should print a message: "Team {team Name} has been created by {user}!".
            // Next you will receive user with team(separated with "->") which means that the user wants to join that team. Upon receiving the command: “end of assignment”, you should print every team, ordered by the count of its members(descending) and then by name(ascending). 
            // For each team, you have to print its members sorted by name(ascending).However, there are several rules:
            // If user tries to create a team more than once a message should be displayed:
            // "Team {teamName} was already created!"
            // Creator of a team cannot create another team -message should be thrown:
            // "{user} cannot create another team!"
            // If user tries to join currently non - existing team a message should be displayed: 
            // "Team {teamName} does not exist!"
            // Member of a team cannot join another team -message should be thrown:
            // "Member {user} cannot join team {team Name}!"
            // In the end(after teams' report) teams with zero members (with only a creator) should disband ordered by name in ascending other. 
            


            var teams = new List<Team>();
            var joinedMembers = new List<string>();

            int nOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < nOfTeams; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                var creator = tokens[0];
                var teamToCreate = tokens[1];

                if (teams.Any(x => x.teamName == teamToCreate))
                {
                    Console.WriteLine($"Team {teamToCreate} was already created!");
                    continue;
                }

                if (teams.Any(x => x.creatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                teams.Add(new Team(teamToCreate, creator));
                joinedMembers.Add(creator);
                Console.WriteLine($"Team {teamToCreate} has been created by {creator}!");
            }
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                var tokens = input.Split(new string[] { "->" }, StringSplitOptions.None).ToArray();
                var name = tokens[0];
                var teamToJoin = tokens[1];

                if (!teams.Any(x => x.teamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                if (joinedMembers.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamToJoin}!");
                    input = Console.ReadLine();
                    continue;
                }

                teams.Single(x => x.teamName == teamToJoin).teamMembers.Add(name);
                joinedMembers.Add(name);

                input = Console.ReadLine();
            }

            foreach (var team in teams.OrderByDescending(x => x.teamMembers.Count).ThenBy(x => x.teamName))
            {
                if (team.teamMembers.Count > 0)
                {
                    Console.WriteLine(team.teamName);
                    Console.WriteLine("- " + team.creatorName);
                    foreach (var member in team.teamMembers.OrderBy(x => x))
                    {
                        Console.WriteLine("-- " + member);
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(x => x.teamMembers.Count == 0).OrderBy(x => x.teamName))
            {
                Console.WriteLine(item.teamName);
            }

        }
    }

    public class Team
    {
        public string teamName;
        public string creatorName;
        public List<string> teamMembers = new List<string>();
        public Team(string TeamName, string CreatorName)
        {
            this.teamName = TeamName;
            this.creatorName = CreatorName;
        }
    }
}