int[] rowsAndColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = rowsAndColumns[0];
int cols = rowsAndColumns[1];

int[,] matrix = new int[rows,cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = rowElements[col];
    }
}

int sum = 0;

foreach(int element in matrix)
{
    sum += element;
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);
