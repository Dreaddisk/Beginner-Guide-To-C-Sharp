using System;

public class HypotenuseCalc
{
    static public void Main()
    {
        string sideA;
        string sideB;

        Console.Clear();
        Console.WriteLine("Let's Calculate Hypotenuse");
        Console.WriteLine("Please enter the length of Side A: ");
        sideA = Console.ReadLine();
        Console.WriteLine("Please enter the length of Side B: ");
        sideB = Console.ReadLine();

        float a = Convert.ToSingle(sideA);
        float b  = Convert.ToSingle(sideB);
        double h2 = Math.Pow(a,2) + Math.Pow(b,2);
        double h = Math.Sqrt(h2);

        Console.WriteLine("The length is {0}", h);
    }
}