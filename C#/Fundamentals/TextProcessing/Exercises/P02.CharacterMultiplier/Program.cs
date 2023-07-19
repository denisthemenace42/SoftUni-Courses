string[] tokens = Console.ReadLine().Split();

string firstWord = tokens[0];
string secondWord = tokens[1];

int result = SumOfCodes(firstWord, secondWord);

Console.WriteLine(result);

static int SumOfCodes(string firstWord, string secondWord)
{

    int sum = 0;
    int minLength = Math.Min(firstWord.Length, secondWord.Length);

    for (int i = 0; i < minLength; i++)
    {

        sum += firstWord[i] * secondWord[i];
    }

    if (firstWord.Length > secondWord.Length)
    {

        for (int i = minLength; i < firstWord.Length; i++)
        {

            sum += firstWord[i];
        }
    }

    else if (firstWord.Length < secondWord.Length)
    {

        for (int i = minLength; i < secondWord.Length; i++)
        {

            sum += secondWord[i];
        }
    }
    return sum;
}