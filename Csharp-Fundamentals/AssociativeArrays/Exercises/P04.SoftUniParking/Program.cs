using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
int commandsCount = int.Parse(Console.ReadLine());

Dictionary<string,User> database = new Dictionary<string, User>();

for (int i = 0; i < commandsCount; i++){

    string[] tokens = Console.ReadLine().Split();
    string command = tokens[0];
    string userName = tokens[1];


    switch (command){

        case "register":
        string licensePlate = tokens[2];
        User user = new User(userName,licensePlate);
        if (!database.ContainsKey(user.UserName)){

            database.Add(user.UserName,user);
            Console.WriteLine($"{user.UserName} registered {user.LicensePlate} successfully");

        }
        else {
            User foundUser = database[user.UserName];

            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlate}");
        }
        break;
        case "unregister":
        if (database.ContainsKey(userName)){

            database.Remove(userName);
            Console.WriteLine($"{userName} unregistered successfully");
        }
        else {

            Console.WriteLine($"ERROR: user {userName} not found");
        }

        break;

    }
    
}

foreach (User user in database.Values){

    Console.WriteLine(user);
}

public class User 
{
    public User(string userName, string licensePlate)
    {
        UserName = userName;
        LicensePlate = licensePlate;
    }

    public string UserName {get; set;}

     public string LicensePlate {get;set;}

    public override string ToString()
    {
        return $"{UserName} => {LicensePlate}";
    }

}