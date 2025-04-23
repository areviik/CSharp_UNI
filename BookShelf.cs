using System;

class Bookshelf
{
    private string[,] b;

    public Bookshelf(int rows, int cols)
    {
        b = new string[rows, cols];
    }

    public string this[int r, int c]
    {
        get
        {
            if (r >= 0 && r < b.GetLength(0) && c >= 0 && c < b.GetLength(1))
                return b[r, c];
            return "Invalid position";
        }
        set
        {
            if (r >= 0 && r < b.GetLength(0) && c >= 0 && c < b.GetLength(1))
                b[r, c] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Bookshelf shelf = new Bookshelf(2, 3);

        shelf[0, 0] = "The Master and Margarita";
        shelf[0, 1] = "Crime and Punishment";

        Console.WriteLine(shelf[0, 0]); 
        Console.WriteLine(shelf[0, 1]); 
        Console.WriteLine(shelf[2, 0]); 
    }
}
