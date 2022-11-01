using System;

class Program
{
    static void Main()
    {
        Fizzbuzz();
    }

    static void Fizzbuzz()
    {

        for (int i = -50; i < 100; i++)
        {           
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }
}