using System.ComponentModel.DataAnnotations;

int dimension = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimension,dimension];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = rowElements[col];
    }
}
// 1 2 3
// 4 5 6
// 7 8 9
int sum = 0; 
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (row == col)
        {
            sum += matrix[row,col];
        } 
    }
}

Console.WriteLine(sum);


