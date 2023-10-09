int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size,size];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = numbers[col];
    }

}

int primaryDiagonal = 0;
int secondaryDiagonal = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
       if ( row == col)
       {
        primaryDiagonal += matrix[row,col];
       }

        if ( size - 1 - row == col)
        {
            secondaryDiagonal += matrix[row,col];
        }
    }
}

Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));