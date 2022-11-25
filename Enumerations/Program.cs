using System;

class Program
{




    static void Main()
    {Enums enums = new Enums();
       
        Enums.Months currentMonth = Enums.Months.November;
        Enums.WeekDays currentDay =  Enums.WeekDays.Tuesday;
        Enums.Season currentSeason = Enums.Season.Autumn;

        Enums.Level level = Enums.Level.High;

        switch (level)
        {
            case Enums.Level.Low:
                Console.WriteLine("low level");
                break;
            case Enums.Level.Medium:
                Console.WriteLine("medium level");
                break;
            case Enums.Level.High:
                Console.WriteLine("high level");
                break;
            default:
                return;
        }

        string test = "pluto";

        Console.WriteLine(Enum.GetName(typeof(Enums.Planets), 5));
        Console.WriteLine(Enum.GetNames(typeof(Enums.Planets)));
        

        Console.WriteLine(currentMonth);
        Console.WriteLine(currentDay);
        Console.WriteLine(currentSeason);

        
    }
}

