using System;

class Program
{
    static int x = 0;
    static int y = 0;
    static int n;
    static void Main()
    {

        Console.WriteLine(Fibonacci(Convert.ToInt32(Console.ReadLine())));


    }

    public static long Fibonacci(int num)
    {
        long a = 0;
        long b = 1;

        for (int i = 0; i < num; i++)
        {
            long temp = a;
            a = b;
            b = temp + b;
            Console.WriteLine(a);
        }
        return a;
    }
}