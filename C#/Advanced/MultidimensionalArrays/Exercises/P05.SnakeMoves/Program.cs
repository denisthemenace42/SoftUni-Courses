using System.Reflection;

int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
string str = Console.ReadLine();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];

Queue<char> snake = new Queue<char>(str);

for (int row = 0; row < rows; row++)
{
    if (row % 2 != 0)
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            char symbol = snake.Dequeue();
            matrix[row,col] = symbol;
            snake.Enqueue(symbol);
        }
    }
    else
    {
        for (int i = 0; i < cols;i++)
        {
            char symbol = snake.Dequeue();
            matrix[row,i] = symbol;
            snake.Enqueue(symbol);
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write($"{matrix[row, col]}");
    }

    Console.WriteLine();
}