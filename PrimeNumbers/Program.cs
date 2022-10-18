using System;
class Program
{
    static void Main()
    {
        //Declaration  
        bool isPrime = true;
        int i; 
        int j = 2;
        //Calculate and display the Prime number  
        Console.WriteLine("Prime Numbers are : ");
        for (i = 2; i >= j; i++)
        {
            for (j = 2; j <= i; j++)
            { 
                Console.WriteLine(j);
                   
                if (i != j && i % j == 0)
                {
                   
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
            }
            isPrime = true;
        }
        Console.ReadKey();
    }
}