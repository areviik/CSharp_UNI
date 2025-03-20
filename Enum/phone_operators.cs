using System;

enum PhoneOper
{
    Beeline,
    MTS,
    Ucom
}

class Program
{
    static void GetCode(PhoneOper op)
    {
        switch(op)
        {
            case PhoneOper.Beeline:
                Console.Write("Beeline codes: 091, 095, 096, 097, 091");
                break;
            case PhoneOper.MTS:
                Console.Write("MTS codes: 077, 093, 094, 095");
                break;
            case PhoneOper.Ucom:
                Console.Write("Ucome codes: 060, 091, 077");
                break;
            default:
                Console.Write("Unknown");
                break;
        }
    }

    static void Main()
    {
        PhoneOper inputOp = PhoneOper.Ucom;
        GetCode(inputOp);
    }
}