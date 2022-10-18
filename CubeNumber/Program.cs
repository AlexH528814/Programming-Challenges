using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input a number and I'll tell you the cube of it");

        int a = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < a; i++)
        {
            Console.WriteLine($"Number is: {i} and the cube of {i} is {i * i * i}");
        }

      
    }
}