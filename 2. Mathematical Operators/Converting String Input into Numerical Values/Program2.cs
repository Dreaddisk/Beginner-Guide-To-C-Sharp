using System;

public class MySecondCalculator
{
    static public void Main()
    {
        string number1, number2;
        int num1, num2;
        Console.Clear();
        Console.WriteLine("Please Enter value 1: ");
        number1 = Console.ReadLine();
        Console.WriteLine("Please Enter value 2: ");
        number2 = Console.ReadLine();

        num1 = Convert.ToInt32(number1);
        num2 = Convert.ToInt32(number2);

        Console.WriteLine("The addition of {0} and {1} is {2}", num1, num2, num1+num2);
    }
}