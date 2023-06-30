using System.Linq;
int teamCounts = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();

for (int i = 0; i<teamCounts; i++){

    string[] tokens = Console.ReadLine().Split("-").ToArray();
    string teamName = tokens[1];
    string creator = tokens[0];

    if (teams.Any(x => x.Name == teamName)){

        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }
    if (teams.Any(x => x.Creator == creator)){

        Console.WriteLine($"{creator} cannot create another team!");
        continue;
    }

    Team team = new Team(teamName,creator);
    teams.Add(team);
    
    Console.WriteLine($"Team {teamName} has been created by {creator}!");
}

string input;

while ((input = Console.ReadLine()) != "end of assignment"){

    string[] tokens = input.Split("->").ToArray();
    string user = tokens[0];
    string teamName = tokens[1];

    if (!teams.Any(x => x.Name == teamName)){

        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (teams.Any(x => x.Members.Contains(user))){

        Console.WriteLine($"Member {user} cannot join team {teamName}!");
        continue;
    }

    Team team = teams.First(x => x.Name == teamName);
    team.Members.Add(user);
}

List<Team> teamsWithMembers = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

foreach(Team team in teamsWithMembers){

    Console.WriteLine($"{team.Name}");
    Console.WriteLine($"- {team.Creator}");

    foreach(string member in team.Members.OrderBy(m => m)){

        Console.WriteLine($"-- {member}");
    }
}

List<Team> disbandedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
Console.WriteLine("Teams to disband:");
foreach (Team team in disbandedTeams){

    Console.WriteLine(team.Name);
}

public class Team
{
    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }

    public string Name {get;set;}

    public string Creator {get;set;}

    public List<string> Members {get;set;}
}