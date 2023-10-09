﻿int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows,cols];

for (int row = 0; row < rows; row++)
{
    char[] symbols = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row,col] = symbols[col];
    }
}

int sum = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols-1; col++)
    {
        if (matrix[row,col] == matrix[row,col +1] && 
            matrix[row,col] == matrix[row +1,col] &&
            matrix[row,col] == matrix[row +1,col+1])
        {
            sum++;
        }
        
    }
}

Console.WriteLine(sum);
