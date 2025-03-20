Console.Write("Enter elements num: ");
int el_num = int.Parse(Console.ReadLine());

char[][,] matrix = new char[el_num][,];

for (int i = 0; i < matrix.Length; i++)
{
    Console.Write($"Enter matrix[{i}] colums: ");
    int cols = int.Parse(Console.ReadLine());

    Console.Write($"Enter matrix[{i}] row: ");
    int rows = int.Parse(Console.ReadLine());

    matrix[i] = new char[rows, cols];
}

Random random = new Random();
Console.WriteLine();

for (int i = 0; i < matrix.Length; i++)
{
    int[] letters = new int[26];
    Console.WriteLine($"Matrix[{i}]: ");

    for (int j = 0; j < matrix[i].GetLength(0); j++)
    {
        for (int k = 0; k < matrix[i].GetLength(1); k++)
        {
            matrix[i][j, k] = (char)random.Next('A', 'Z' + 1);
            Console.Write(matrix[i][j, k] + " ");
            letters[matrix[i][j, k] - 'A']++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine($"Letter counts for Matrix[{i}]: ");
    for (int l = 0; l < letters.Length; ++l)
    {
        if (letters[l] > 0)
        {
            Console.WriteLine($"{(char)('A' + l)}: {letters[l]}");
        }
    }
    Console.WriteLine();
}