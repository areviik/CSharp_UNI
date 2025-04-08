using System;
using static System.Console;

class Person
{
    private string personName;

    public string Name
    {
        get { return personName; }
        set { personName = value; } 
    }

    public Person(string name)
    {
        this.Name = name;
    }
}

class Program
{
    static void Main()
    {
        Write("Enter person name: ");
        string name = ReadLine();
        Person p = new Person(name);
        WriteLine("Welcome {0}!", p.Name);
    }
}