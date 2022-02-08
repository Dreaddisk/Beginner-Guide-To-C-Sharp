using System;

public class Challenge1
{
    static public void Main()
    {
        // In this exercise create a Program that enters the name, age
        // job title, and company of a person.

        string your_name;
        string your_age;
        string companyName;
        string jobTitle;

        // ask name
        Console.WriteLine("What is your name?:");
        your_name = Console.ReadLine(); // Prompt your name
        // ask age
        Console.WriteLine("What is your age?");
        your_age = Console.ReadLine();  // Propmt your age.
        // Ask JOb title
        Console.WriteLine("What is your job title?");
        jobTitle = Console.ReadLine();  // Prompt Job title
        // ask company name
        Console.WriteLine("Where do you work?");
        companyName = Console.ReadLine();   // Prompt Company Name
        Console.WriteLine("|***************\n***************|");
        Console.WriteLine("|Name:{0,10}|", your_name);
        Console.WriteLine("|Age:{0,10}|", your_age);
        Console.WriteLine("|Job title:{0,20}|", jobTitle);
        Console.WriteLine("|Company:{0,22}|", companyName);
        Console.WriteLine("|***************\n***************|");
    }
}