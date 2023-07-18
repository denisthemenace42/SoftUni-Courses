string input = Console.ReadLine();

Console.WriteLine(MiddleCharacters(input));

static string MiddleCharacters(string input){

int l = 1 - input.Length % 2;

return input.Substring(input.Length / 2 - l , 1 + l);

}