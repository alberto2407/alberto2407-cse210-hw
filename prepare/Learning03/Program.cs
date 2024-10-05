using System;

class Program
{
    static void Main(string[] args)
    {
        Fration fration1 = new Fration();
        Console.WriteLine(fration1.GetFractionString());
        Console.WriteLine(fration1.GetDecimalValue());

        Fration fration2 = new Fration(5);
        Console.WriteLine(fration2.GetFractionString());
        Console.WriteLine(fration2.GetDecimalValue());

        Fration fration3 = new Fration(3, 4);
        Console.WriteLine(fration3.GetFractionString());
        Console.WriteLine(fration3.GetDecimalValue());

        Fration fration4 = new Fration(1, 3);
        Console.WriteLine(fration4.GetFractionString());
        Console.WriteLine(fration4.GetDecimalValue());

    }
}