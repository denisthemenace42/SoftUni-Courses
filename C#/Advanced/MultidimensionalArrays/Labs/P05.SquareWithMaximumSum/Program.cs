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

int[,] bestMatrix = new int[2,2];
int maxSum = 0; 

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int sum = matrix[row,col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (sum > maxSum)
        {
            bestMatrix[0,0] = matrix[row,col];
            bestMatrix[0,1] = matrix[row, col + 1];
            bestMatrix[1,0] = matrix[row + 1, col];
            bestMatrix[1,1] = matrix[row + 1, col + 1];

            maxSum = sum;
        }
       
    }
}

Console.WriteLine($"{bestMatrix[0,0]} {bestMatrix[0,1]}");
Console.WriteLine($"{bestMatrix[1,0]} {bestMatrix[1,1]}");
Console.WriteLine(maxSum);

