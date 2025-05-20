using System;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Grade: {Grade}");
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student("Aram", 5);
        s.PrintInfo(); 
    }
}
