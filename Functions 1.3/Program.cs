using System;
using System.ComponentModel;

class Program
{
    static int total;
    public static void Main()
    {
        Console.WriteLine("Give me 4 numbers");
        totalint(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


    }
    public static void totalint(int f, int g, int h, int j)
    {
        int total = f + g + h + j;
        Console.WriteLine(total);

        evenbig(total);
    }

    public static void evenbig(int i)
    {
        bool bignum;


        if (i % 2 != 0)
        {
            Console.WriteLine("The number was not even so I added 1 to it");
            i = i + 1;
            Console.WriteLine(i);
        }

        else if (i % 2 == 0)
        {
            Console.WriteLine("the number was even so I kept it the same");
            Console.WriteLine(i);
        }

        if (i >= 10)
        {
            bignum = true;
            Console.WriteLine("The number was greater than 10, so the bool is");
            Console.WriteLine(bignum);
        }

        else if (i < 10)
        {
            bignum = false;
            Console.WriteLine("The number was smaller than 10, so the bool is");
            Console.WriteLine(bignum);
        }
    }
}