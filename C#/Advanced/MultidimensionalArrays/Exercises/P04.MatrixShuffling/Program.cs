int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (tokens[0] == "swap" && tokens.Length == 5)
    {
        int row1 = int.Parse(tokens[1]);
        int col1 = int.Parse(tokens[2]);
        int row2 = int.Parse(tokens[3]);
        int col2 = int.Parse(tokens[4]);

        if (row1 < rows && col1 < cols && row2 < rows && col2 < cols
           && row1 >= 0 && col1 >= 0 && row2 >= 0 && col1 >= 0)
        {
            string element1 = matrix[row1,col1];
            string element2 = matrix[row2,col2];
            
            matrix[row1,col1] = element2;
            matrix[row2,col2] = element1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}