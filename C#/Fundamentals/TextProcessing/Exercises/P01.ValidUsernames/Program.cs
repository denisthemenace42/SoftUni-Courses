List<string> usernames = Console.ReadLine().Split(", ").ToList();

foreach (string username in usernames){

    if (isValidUsername(username)){

        Console.WriteLine(username);
    }
}

static bool isValidUsername(string username)
{

    if (username.Length < 3 || username.Length > 16)
    {

        return false;
    }

    foreach (char x in username)
    {

        if (!char.IsLetterOrDigit(x) && x != '-' && x != '_')
        {

            return false;
        }
    }

    return true;
}