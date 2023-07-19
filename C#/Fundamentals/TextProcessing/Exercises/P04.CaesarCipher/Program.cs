using System.Text;
string input = Console.ReadLine();

Console.WriteLine(Encrypt(input));

static string Encrypt(string input)
{

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < input.Length; i++)
    {

        char originalChar = input[i];

        sb.Append((char)(originalChar + 3));
    }
    return sb.ToString();


}