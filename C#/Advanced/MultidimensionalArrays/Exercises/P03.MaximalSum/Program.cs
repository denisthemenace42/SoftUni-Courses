int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix = new int[rows,cols];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row,col] = numbers[col];
    }
}

int sum = int.MinValue;
int[,] newMatrix = new int[3,3];

for (int row = 0; row < rows - 2 ; row++)
{
    for (int col = 0; col < cols - 2 ; col++)
    {
        int matrixSum = matrix[row,  col]   +   matrix[row+1,col] +   matrix[row+2,col] +
                        matrix[row,  col+1] + matrix[row+1,col+1] + matrix[row+2,col+1] +
                        matrix[row,  col+2] + matrix[row+1,col+2] + matrix[row+2,col+2];
                         

        if (matrixSum > sum)
        {
            sum = matrixSum;
            newMatrix[0,0] = matrix[row,col];
            newMatrix[1,0] = matrix[row+1,col];
            newMatrix[2,0] = matrix[row+2,col];
            newMatrix[0,1] = matrix[row,col+1];
            newMatrix[1,1] = matrix[row+1,col+1];
            newMatrix[2,1] = matrix[row+2,col+1];
            newMatrix[0,2] = matrix[row,col+2];
            newMatrix[1,2] = matrix[row+1,col+2];
            newMatrix[2,2] = matrix[row+2,col+2];
        }              
    }
}

Console.WriteLine($"Sum = {sum}");

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
       Console.Write($"{newMatrix[row,col]} ");
    }
    
    Console.WriteLine();
}