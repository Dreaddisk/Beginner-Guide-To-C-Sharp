using System;

public class Math
{
    static public void Main()
    {
        // create the integer variables
        int number1 = 5;
        int number2 = 3;
        int total, total1, total2, total3;
        float floatResult;
        double moduleResult;


        // place the equations.
        total = number1 + number2;
        total1 = number1 - number2;
        total2 = number1 * number2;
        total3 = number1 / number2;
        floatResult = number1 / (float)number2;
        moduleResult = number1 % (double)number2;


        Console.WriteLine("{0}", total);
        Console.WriteLine("{0}", total1);
        Console.WriteLine("{0}", total2);
        Console.WriteLine("{0}", total3);
        Console.WriteLine("{0}", floatResult);
        Console.WriteLine("{0}", moduleResult);
    }
}