using System;

class Program
{

    public static void Main()
    {
        int tribase = 4;
        int height = 5;

        triArea(tribase, height);
    }

    public static void triArea(int tribase, int height)
    {
        Console.WriteLine(tribase * height / 2);
    }

}

