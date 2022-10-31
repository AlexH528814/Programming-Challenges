using System;
using System.ComponentModel;

class Program
{
   
    public static void Main()
    {
        Console.WriteLine("Give me 4 numbers");
        totalint(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
    }
    public static int totalint(int a, int b, int c, int d)
    {
        int total = a + b + c + d;
        return total;

        evenbig(total);
        
    }

    public static bool evenbig(int i)
    {
        if (i % 2 != 0)
        {         
            i = i + 1;
            return false;
        }

        else
        {        
            return true;
        }      
    }
}