using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {

        Random random = new Random();


        int a = random.Next(1, 50);
        int b = random.Next(1, 50);
        int c = 0;


        Console.WriteLine($"You have been given two numbers, those numbers are {a} and {b}");
        Console.WriteLine("What would you like to do to them? [*] [/] [+] [-]");
        string input = Console.ReadLine();

        if (input != "*" || input != "/" || input != "+" || input != "-")
            return;

        else switch (input)
            {
                case "*":
                    c = a * b;
                    
                    break;
                case "/":
                    c = a / b;
                   
                    break;
                case "+":
                    c = a + b;
                    
                    break;
                case "-":
                    c = a - b;
                 
                    break;
            }

        
        Console.WriteLine($"New number is {c}");

    }
}