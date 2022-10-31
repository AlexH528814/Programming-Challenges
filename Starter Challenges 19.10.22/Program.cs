using System;

class Program
{
    static void Main()
    {
        Quadrat();
        Factors();
    }

    static void Factors()
    {
        Console.WriteLine("give me a number and I'll tell you its factors");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                Console.WriteLine(i);
            }



        }
    }

    static void Quadrat()
    {

        Console.WriteLine("Give me 2 coordinates");
        int xcoord = Convert.ToInt32(Console.ReadLine());
        int ycoord = Convert.ToInt32(Console.ReadLine());

        if (xcoord == 0 && ycoord == 0)
        {
            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies in the origin");
        }

        else if (xcoord >= 0 && ycoord >= 0)
        {
            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) quadrat 1");
        }

        else if (xcoord <= 0 && ycoord <= 0)
        {
            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) quadrat 3");
        }

        else if (xcoord >= 0 && ycoord <= 0)
        {
            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) quadrat 4");
        }

        else if (xcoord <=  0 && ycoord >= 0)
        {
            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) quadrat 2");
        }

        
    }
}