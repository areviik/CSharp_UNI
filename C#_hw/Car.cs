using System;
using static System.Console;

class Car
{
    private string modelName;

    public string Model
    {
        get => modelName;
        set => modelName = value;
    }

    public Car(string modelName)
    {
        this.modelName = modelName;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Ferrari");
        WriteLine("Car model 1: {0}", myCar.Model);
        myCar.Model = "Toyota";
        WriteLine("Car model 2: {0}", myCar.Model);
    }
}