int[] rowsAndColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = rowsAndColumns[0];
int cols = rowsAndColumns[1];

int[,] matrix = new int[rows,cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = rowElements[col];
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
   int sum = 0;

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    sum += matrix[i,col];
   }

   Console.WriteLine(sum);
}

