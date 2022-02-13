 using System;

public class Convertion
{
    static public void Main()
    {
        // Create a money convertion rate app.

        // create thje variables for the convertion
        float US_Dollar;
        float convertionRate;
        double total;

        // Prompt the value of the dollar.
        Console.WriteLine("How much money you wish to convert?: ");
        US_Dollar = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("What is the rate value that you wish to convert your money?: ");
        convertionRate = Convert.ToSingle(Console.ReadLine());

        // Calculate the convertion
        total = (convertionRate * US_Dollar);

        Console.WriteLine("Your total is {0:0.00}", total);
    }
}