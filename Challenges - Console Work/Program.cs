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

        bool attackmode = false;

        Console.WriteLine("You encountered an enemy, press C, R, Y or F to attack it");
        attackmode = true;

        while (attackmode == true)
        {
            if (enemyHealth <= 0)
            {
                Console.WriteLine("You defeated the enemy");
                attackmode = false;
                Environment.Exit(0);
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("The enemy defeated you");
                attackmode = false;
                Environment.Exit(0);
            }

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
                    break;

                case ConsoleKey.R:

                    enemyHealth = enemyHealth - playerDamage2;
                    Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                    Console.WriteLine($"The enemy now has {enemyHealth} health");
                    playerHealth = enemyHealth - enemyDamage;
                    Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                    break;

                case ConsoleKey.Y:

                    enemyHealth = enemyHealth - playerDamage3;
                    Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                    Console.WriteLine($"The enemy now has {enemyHealth} health");
                    playerHealth = enemyHealth - enemyDamage;
                    Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                    break;

                case ConsoleKey.F:

                    enemyHealth = enemyHealth - playerDamage4;
                    playerHealth = enemyHealth - enemyDamage;
                    Console.WriteLine($"You attacked the enemy for {playerDamage1}");
                    Console.WriteLine($"The enemy now has {enemyHealth} health");
                    Console.WriteLine($"The enemy attacked you in retaliation, your health is now {playerHealth}");
                    break;

                default:
                    Console.WriteLine("That was not one of the options");
                    break;
            }

            if (enemyHealth <= 0)
            {
                enemyHealth = 0;
            }

            if (playerHealth <= 0)
            {
                playerHealth = 0;
            }

        }


    }
}