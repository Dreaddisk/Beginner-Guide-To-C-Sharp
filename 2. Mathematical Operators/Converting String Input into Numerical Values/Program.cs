using System;

public class MyCalculator
{
    static public void Main()
    {
        // C = 2*PI*R
        string radius;
        Console.Clear();
        Console.WriteLine("Please, enter the radius: ");
        radius = Console.ReadLine();

        float rad = Convert.ToSingle(radius);
        float c = 2 * 3.14f * rad;
        Console.WriteLine("The circunference is {0}",  c);
    }
}