using System;

class Program
{
    public static void Main()
    {
        int numofinvalids = 0;
        List<string> NameList = new List<string>();

        NameList.Add("Biff");
        NameList.Add("Chip");
        NameList.Add("Kipper");
        NameList.Add("Hans");
        NameList.Add("Super");
       


        Console.WriteLine("Number of numbers in list is " + NameList.Count);

        for (int i = 0; i <= NameList.Count; i++)
        {
            string curname = (NameList.ElementAt(i));
            int letters = 0;
            letters = curname.Length;



            if (letters > 4)
            {
                Console.WriteLine("Invalid");
                NameList.RemoveAt(i);
                numofinvalids++;
            }

            else
            {
                Console.WriteLine((NameList.ElementAt(i)));
            }


        }

       

        Console.WriteLine(NameList.Count);



    }
}