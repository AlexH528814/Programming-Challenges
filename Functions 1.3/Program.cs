using System;
using System.ComponentModel;

class Program
{
   
    public static void Main()
    {
       
       
        Console.WriteLine("Give me 4 numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int total = totalint(a, b, c, d);;
      
        bool evenodd = evenbig(total);
        Console.WriteLine(evenodd);
        
    }
    public static int totalint(int a, int b, int c, int d)
    {
        int total = a + b + c + d;
        Console.WriteLine(total);
        return total;

     
        
    }

    public static bool evenbig(int total)
    {
        if (total % 2 != 0)
        {         
            total = total + 1;
            return false;
        }

        else
        {        
            return true;
        }      
    }
}