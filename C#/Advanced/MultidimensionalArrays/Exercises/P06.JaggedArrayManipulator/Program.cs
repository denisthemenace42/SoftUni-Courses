int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    matrix[i] = numbers;
}

for (int row = 0; row < rows - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        for (int i = 0; i < matrix[row].Length; i++)
        {
            matrix[row][i] *= 2;
            matrix[row + 1][i] *= 2;
        }
    }
    else
    {
        for (int i = 0; i < matrix[row].Length; i++)
        {
            matrix[row][i] /= 2;
        }

        for (int i = 0; i < matrix[row + 1].Length; i++)
        {
            matrix[row + 1][i] /= 2;
        }
    }
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();

    string command = tokens[0];
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (row < rows && row >= 0 && col >= 0 && col < matrix[row].Length)
    {
        switch (command)
        {
            case "Add":
                matrix[row][col] += value;
                break;
            case "Subtract":
                matrix[row][col] -= value;
                break;
        }
    }
}

for (int i = 0; i < rows; i++)
{
    Console.WriteLine(String.Join(" ", matrix[i]));
}
