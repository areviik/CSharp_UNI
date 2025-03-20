using System;

class Car
{
    private string brand;
    private string model;
    private int year;

    public Car(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public void Display()
    {
        Console.WriteLine($"Car: {brand}, Model: {model}, Year: {year}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", "Corolla", 2020);
        car.Display();
    }
}
