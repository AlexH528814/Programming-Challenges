using System;


class Program
{
    public static void Main()
    {
        int numofinvalids = 0;
        List<string> NameList = new List<string>();

        NameList.Add("Biff");
        NameList.Add("Chips");
        NameList.Add("Kipper");
        NameList.Add("Super");
        NameList.Add("Hans");

        Console.WriteLine($"Number of names in list is {NameList.Count}");

        for (int i = 0; i < NameList.Count; i++)
        {
            Thread.Sleep(1000);
            string curname = (NameList.ElementAt(i));
            int letters = 0;
            letters = curname.Length;

            if (letters != 4)
            {
                Console.WriteLine("Invalid");
                numofinvalids++;
            }
            else
            {
                Console.WriteLine(curname);
            }
        }
        Console.WriteLine($"Num of invalids is: {numofinvalids}");
    }
}