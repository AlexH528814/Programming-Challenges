using System;

class Program
{

    public static void EqualSlices(int total, int people, int each)
    {
        bool sliceable;

        if (people * each > total)
        {
            sliceable = false;
            Console.WriteLine(sliceable);
            
        }

        else
        {
            sliceable = true;
            Console.WriteLine(sliceable);
        }
    }

    static void Main()
    {
        EqualSlices(10, 3, 3);

        Console.WriteLine("Input the radius of a sphere and I'll tell you the volume and surface area of it");
        double PI = 3.1415926535897931;
        int r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The radius of your sphere is {r}");
        Console.WriteLine("The volume of your sphere is " + (r*r*r) * (1.333333333333) * (PI));
        Console.WriteLine("The surface area of your sphere is " + (4*PI) * (r*r));
    }
}