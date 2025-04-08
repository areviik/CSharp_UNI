using System;
using static System.Console;

class Student
{
    private int studentAge;

    public int Age
    {
        get { return studentAge; }
        set
        {
            if (value < 0 || value > 120)
            {
                WriteLine("Invalid input!");
            }
            else
            {
                studentAge = value;
            }
        }
    }

    public Student(int age)
    {
        this.Age = age;
    }
    public void Display()
    {
        WriteLine($"Student age is {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student st = new Student(19);
        st.Display();
        st.Age = 290; 
    }
}