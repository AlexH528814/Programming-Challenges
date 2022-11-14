using System;

class Program
{
    static void Main()
    {
        int spaces = Convert.ToInt32(Console.ReadLine());
        int stars = Convert.ToInt32(Console.ReadLine());

        Drawstars(spaces, stars);

    }

    static void Drawstars(int spaces, int stars)
    {
        for (int i = 0; i <= spaces; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i <= stars; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");



    }
}