using System;

class Program
{
    static void Main()
    {
        int birthyear = Convert.ToInt32(Console.ReadLine());
        int birthmonth = Convert.ToInt32(Console.ReadLine());
        int birthday = Convert.ToInt32(Console.ReadLine());


        string year = DateTime.Now.Year.ToString();
        int curryear = Convert.ToInt32(year);

        string month = DateTime.Now.Month.ToString();
        int currmonth = Convert.ToInt32(month);

        string day = DateTime.Now.Day.ToString();
        int currday = Convert.ToInt32(day);


        if (curryear - birthyear >= 18 && currmonth >= birthmonth && currday >= birthday)
        {
            Console.WriteLine("You are old enough to vote");
        }

        else
            Console.WriteLine("You cant vote");

    }
}