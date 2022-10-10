using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerDamage1 = random.Next(10, 15);
        int playerDamage2 = random.Next(15, 20);
        int playerDamage3 = random.Next(5, 10);
        int playerDamage4 = random.Next(20, 25);
        int enemyDamage = random.Next(10, 15);

        int playerHealth = 150;
        int enemyHealth = 150;



        Console.WriteLine("You encountered an enemy, press C, R, Y or F to attack it");

        answerfunc();

        if (enemyHealth <= 0)
        {
            Console.WriteLine("You defeated the enemy");
            Environment.Exit(0);
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("The enemy defeated you");
            Environment.Exit(0);
        }


    }


    static void answerfunc()
    {
        Random random = new Random();
        int playerDamage1 = random.Next(10, 15);
        int playerDamage2 = random.Next(15, 20);
        int playerDamage3 = random.Next(5, 10);
        int playerDamage4 = random.Next(20, 25);
        int enemyDamage = random.Next(10, 15);
        int playerHealth = 150;
        int enemyHealth = 150;


        var input = Console.ReadKey();
        Console.WriteLine("");
        switch (input.Key)
        {
            case ConsoleKey.C:
                
                enemyHealth = enemyHealth - playerDamage1;
                Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                Console.WriteLine($"The enemy now has {enemyHealth} health");
                playerHealth = enemyHealth - enemyDamage;
                Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                answerfunc();
                break;

            case ConsoleKey.R:
               
                enemyHealth = enemyHealth - playerDamage2;
                Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                Console.WriteLine($"The enemy now has {enemyHealth} health");
                playerHealth = enemyHealth - enemyDamage;
                Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                answerfunc();
                break;

            case ConsoleKey.Y:
                
                enemyHealth = enemyHealth - playerDamage3;
                Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                Console.WriteLine($"The enemy now has {enemyHealth} health");
                playerHealth = enemyHealth - enemyDamage;
                Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                answerfunc();
                break;

            case ConsoleKey.F:
              
                enemyHealth = enemyHealth - playerDamage4;
                Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                Console.WriteLine($"The enemy now has {enemyHealth} health");
                playerHealth = enemyHealth - enemyDamage;
                Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                answerfunc();
                break;

            default:
                Console.WriteLine("That was not one of the options");
                answerfunc();
                break;
        }


    }

    

}