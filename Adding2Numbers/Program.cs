using System;
class Program
{
    //Add numbers function
    static int Addnumbers(int x, int y)
    {
        int newValue = x + y;
        return newValue;
    }

    static void Main()
    {
        Console.WriteLine(Addnumbers(4, 9));

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a + b);



        //Superman vs Batman if else
        Console.WriteLine("Who is your favourite superhero, batman or superman");
        string hero = Console.ReadLine();

        if (hero == "Superman" || hero == "superman")
        {
            Console.WriteLine("you are lame");
        }

        else if (hero == "Batman" || hero == "batman")
        {
            Console.WriteLine("you are cool");
        }

        else
        {
            Console.WriteLine("They dont exist (I'm not gaslighting you)");
        }


        //Superman vs Batman Switch
        string hero2 =Console.ReadLine();
        switch (hero2.ToLower())
        {
            case "saitama":
                Console.WriteLine("One Punch");
                break;

            case "spiderman":
                Console.WriteLine("Man like a spider");
                break;

            case "hawkeye":
                Console.WriteLine("guy with a bow an arrow");
                break;

            case "hindsight lad":
                Console.WriteLine("literally a guy who hashindsight");
                break;

            case "kiteman":
                Console.WriteLine("guy with a kite");
                break;

            default:
                Console.WriteLine("They dont exist (I'm not gaslighting you)");
                break;
        }

        //Call a function
        hellofunction("Hello");

    } 

    //Call a Function
    static void hellofunction(string f)
    {       
         f = f + "s";
        Console.WriteLine(f);
    }
}