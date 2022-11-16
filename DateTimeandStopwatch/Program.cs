using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Input;


class Program
{



    public static void Main(string[] args)
    {        
        bool onepressed = false;
        bool twopressed = false;
        bool threepressed = false;
        bool fourpressed = false;
        bool fivepressed = false;
        bool sixpressed = false;
        bool sevenpressed = false;
        bool eightpressed = false;
        bool ninepressed = false;
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Started");
        stopwatch.Start();
        var input = Console.ReadKey();
        while (!onepressed || !twopressed || !threepressed || !fourpressed || !fivepressed || !sixpressed || !sevenpressed || !eightpressed || !ninepressed)
        {
            switch (input.Key)
            {
                case ConsoleKey.NumPad1:
                    onepressed = true;
                    Console.WriteLine("One Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad2:
                    twopressed = true;
                    Console.WriteLine("Two Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad3:
                    threepressed = true;
                    Console.WriteLine("Three Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad4:
                    fourpressed = true;
                    Console.WriteLine("Four Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad5:
                    fivepressed = true;
                    Console.WriteLine("Five Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad6:
                    sixpressed = true;
                    Console.WriteLine("Six Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad7:
                    sevenpressed = true;
                    Console.WriteLine("Seven Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad8:
                    eightpressed = true;
                    Console.WriteLine("Eight Pressed");
                    input = Console.ReadKey();
                    break;
                case ConsoleKey.NumPad9:
                    ninepressed = true;
                    Console.WriteLine("Nine Pressed");
                    break;
            }
        }       
            stopwatch.Stop();
            Console.WriteLine("Finshed");
            Console.WriteLine("");
            Console.WriteLine("");

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);       
    }
}




/* int year;
         int month;
         int day;

         string result = "";

         Console.WriteLine("Enter the year");
         year = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the month");
         month = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the day");
         day = Convert.ToInt32(Console.ReadLine());

         if (month <= 12 && month > 0 && day > 0 && day <= 31)
         {
             DateTime dateValue = new DateTime(year, month, day);

             if (day == 25 && month == 12)
                 result = "christmas day";
             else if (day == 1 && month == 1)
                 result = "newyears";


             switch (result)
             {
                 case "christmas day":
                     Console.WriteLine("Merry Christmas");
                     break;

                 case "newyears":
                     Console.WriteLine("Happy New Years");
                     break;

                 default:
                     Console.WriteLine(dateValue.DayOfWeek);
                     break;
             }

         }
        */


