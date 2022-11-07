﻿using System;

public class Character
{
    string characterName;
    int maxHP;
    bool IsPlayer;

    public Character(string _characterName, int _maxHP, bool _IsPlayer)
    {
        characterName = _characterName;
        maxHP = _maxHP;
        IsPlayer = _IsPlayer;
    }

    public void Attack(Character Player)
    {


        Console.WriteLine("Attacking enemy");


        while (Player.maxHP > 0)
        {
            Random random = new Random();
            int damage = random.Next(1, 3);

            Console.WriteLine("Press Space");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Spacebar:

                    Player.maxHP -= damage;
                    Console.WriteLine($"The enemy lost {damage} hp, it now has {Player.maxHP}");

                    Console.WriteLine("The enemy was unable to deal any damage to you");
                    Console.WriteLine("");

                    break;
            }

        }
    }

}
