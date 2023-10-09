int dimension = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimension,dimension];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowElements = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = rowElements[col];
    }
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (symbol == matrix[row,col])
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

Console.WriteLine($"{symbol} does not occur in the matrix");

