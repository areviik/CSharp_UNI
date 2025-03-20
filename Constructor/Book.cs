using System;

class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: ${price}");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("C# Programming", "John Doe", 29.99);
        book.Display();
    }
}
