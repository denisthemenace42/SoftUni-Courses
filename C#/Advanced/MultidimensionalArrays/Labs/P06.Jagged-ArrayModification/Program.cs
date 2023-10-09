using System.Data;

int matrixRows = int.Parse(Console.ReadLine());

int[][] matrix = new int[matrixRows][];

for (int row = 0; row < matrixRows; row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = rowValues;

}

while (true)
{
    string command = Console.ReadLine();

    if (command == "END")
    {
        break;
    }

    string[] tokens = command.Split(" ");
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (row < 0 || row > matrix.Length - 1 || col < 0 || col > matrix[row].Length - 1)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    switch (tokens[0])
    {
        case "Add":
        matrix[row][col] += value;
        break;

        case "Subtract":
        matrix[row][col] -= value;
        break;
    }
}

foreach (int[] array in matrix)
{
    Console.WriteLine(String.Join(" ", array));
}