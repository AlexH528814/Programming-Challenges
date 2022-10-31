using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {

        funcylisty();

    }
    static void funcylisty()
    {
        List<string> AgeList = new List<string>();
        //adding the names
        AgeList.Add("Biff");
        AgeList.Add("Chips");
        AgeList.Add("Hans");
        AgeList.Add("Kipper");
        AgeList.Add("Super");
        int invalids = 0;
        //going through 5 times, 5 names in the list
        for (int i = 0; i < AgeList.Count; i++)
        {
            //wait 1 secvond
            Thread.Sleep(1000);
            //this is the string at the position its at
            string name = AgeList.ElementAt(i);
            int letters = 0;
            //letter count in a word
            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    letters++;

                }
            }
            //for letter in the name
            if (letters > 4)
            {
                //if its greater than 4
                Console.WriteLine("Invalid");
                invalids++;
                // AgeList.Remove(AgeList.ElementAt(i));
            }
            else if (letters <= 4)
            //less than 4
            {
                Console.WriteLine(name);
            }
        }
        Console.WriteLine($"THERE ARE {invalids} INVALIDS");
    }
}