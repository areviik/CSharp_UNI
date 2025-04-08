using System;

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");
        
        Name = name;
    }
}

public class Circle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");
        
        Radius = radius;
    }
}

public class Student
{
    private int _age;
    
    public int Age
    {
        get => _age;
        set
        {
            if (value < 16)
                throw new ArgumentException("Age must be at least 16.");
            
            _age = value;
        }
    }

    public Student(int age)
    {
        Age = age;
    }
}

public class Temperature
{
    private double celsius;

    public double Celsius
    {
        get => celsius;
        set => celsius = value;
    }

    public double Fahrenheit => (Celsius * 9 / 5) + 32;

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }
}

public class Employee
{
    private double _salary;

    public double Salary
    {
        get => _salary;
        set
        {
            if (value < 100 || value > 10000)
                throw new ArgumentException("Salary must be between 100 and 10,000.");
            
            _salary = value;
        }
    }

    public Employee(double salary)
    {
        Salary = salary;
    }
}

public class BankAccount
{
    private double balance;
    public double Balance => balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");
        
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdraw amount must be positive.");
        
        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds.");
        
        balance -= amount;
    }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Perimeter => 2 * (Width + Height);

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be greater than zero.");
        
        Width = width;
        Height = height;
    }
}

public class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Title and Author cannot be empty.");
        
        Title = title;
        Author = author;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Alice");
        Console.WriteLine($"Person Name: {person.Name}");

        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Radius: {circle.Radius}, Area: {circle.Area}");

        Student student = new Student(18);
        Console.WriteLine($"Student Age: {student.Age}");

        Temperature temp = new Temperature(25);
        Console.WriteLine($"Temperature: {temp.Celsius}°C, {temp.Fahrenheit}°F");

        Employee employee = new Employee(3000);
        Console.WriteLine($"Employee Salary: {employee.Salary}");

        BankAccount account = new BankAccount(500);
        account.Deposit(200);
        account.Withdraw(100);
        Console.WriteLine($"BankAccount Balance: {account.Balance}");

        Rectangle rect = new Rectangle(4, 7);
        Console.WriteLine($"Rectangle: Width={rect.Width}, Height={rect.Height}, Perimeter={rect.Perimeter}");

        Book book = new Book("C# in Depth", "Jon Skeet");
        Console.WriteLine($"Book: {book.Title} by {book.Author}");
    }
}
