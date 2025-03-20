using System;

enum Gear
{
    P,
    R, 
    N,
    D
}
class Program
{
    static void PrintMsg(Gear gr)
    {
        switch(gr)
        {
            case Gear.P:
                Console.WriteLine("The car is parked!");
                break;
            case Gear.R:
                Console.WriteLine("The car is moving backward!");
                break;
            case Gear.N:
                Console.WriteLine("The car is in neutral!");
                break;
            case Gear.D:
                Console.WriteLine("The car is moving forward!");
                break;
            default:
                Console.WriteLine("Inknown gear!");
                break;
        }
    }

    static void Main()
    {
        Gear currGear = Gear.D;
        PrintMsg(currGear);
    }
}