using System.Text;
string input = Console.ReadLine();

string output = ProcessExplosion(input);

Console.WriteLine(output);

static string ProcessExplosion(string input)
{
    StringBuilder sb = new StringBuilder();
    int power = 0;

    for (int i = 0; i < input.Length; i++)
    {

        if (input[i] == '>')
        {

            sb.Append(input[i]);

            power += int.Parse(input[i + 1].ToString());
        }
        else if (power == 0)
        {

            sb.Append(input[i]);
        }
        else
        {

            power--;
        }
    }

    return sb.ToString();
}