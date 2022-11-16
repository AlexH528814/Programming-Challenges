using System;

class Program
{
    static void Main()
    {
        int slices;
        int recipients;
        int each;

        Console.Write("Enter the total number of slices:");
        slices = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the total number of recipients:");
        recipients = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of slices each:");
        each = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(EqualSlices(slices, recipients, each));
        
    }

    static bool EqualSlices(int slices, int recipients, int each)
    {
        if (recipients * each <= slices)        
            return true;                

        else
            return false;
        
    }
}
