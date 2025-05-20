using System;

class Vehicle
{
    public string Brand;

    public Vehicle()
    {
        Console.WriteLine("Vehicle was created.");
    }
    public void StartEngine()
    {
        Console.WriteLine("Engine Started.");
    }
}

class Car : Vehicle
{
    public void OpenTrunk()
    {
        Console.WriteLine("Trunk opened");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();      
        myCar.StartEngine();       
        myCar.OpenTrunk();
    }
}