using System;

public class StringExplorer
{
    static public void Main()
    {
        string name = "";
        string age;

        Console.WriteLine("Hello! What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
        /*string s = "My name is Jose";
        s = s + " Puebla";
        */
        Console.WriteLine("Hello! {0}", name);
        Console.WriteLine("I am {0} years old", age);
    }
}