using System;

class Program
{
    static int num1;
    static int num2;
    static string answer1;
    static string answer2;  
    public static void Main(string[] args)
    {

        Console.WriteLine("Input your first number");
        answer1 = Console.ReadLine();
        num1 = Convert.ToInt32(answer1);
        Console.WriteLine("");
        Console.WriteLine("Input your second number");
        answer2 = Console.ReadLine();
        num2 = Convert.ToInt32(answer2);


        if (num1 == num2)
        {
            Console.WriteLine("Both numbers are equal");
        }

        else
        {
            Console.WriteLine("Neither number is equal");
        }

    }
}