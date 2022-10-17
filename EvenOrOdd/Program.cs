using System;

class Program
{
    static void Main()
    {
        


        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine($"The number {a} is even");

          
        }

        else
        {
            Console.WriteLine($"The number {a} is odd");

           
        }
    }
}