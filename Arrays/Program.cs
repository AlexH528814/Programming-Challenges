using System;

class Program
{
    static string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

    static void Main()
    {
        cars[0] = "Opel";

        Array.Sort(cars);

        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}