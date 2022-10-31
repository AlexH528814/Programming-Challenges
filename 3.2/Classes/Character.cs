using System;

public class Character
{
    public string characterName;
    public int maxHP;
    public bool IsPlayer;


    public static void Attack(Character Player, Character Enemy)
    {
        Console.WriteLine("Attacking enemy");


        while (Player.maxHP > 0 && Enemy.maxHP > 0)
        {
            Random random = new Random();
            int damage = random.Next(1, 3);

            Console.WriteLine("Press Space");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Spacebar:

                    Enemy.maxHP -= damage;
                    Console.WriteLine($"The enemy lost {damage} hp, it now has {Enemy.maxHP}");

                    Console.WriteLine("The enemy was unable to deal any damage to you");
                    Console.WriteLine("");

                    break;
            }

        }
    }

}
