using System;

public class Game
{
    public static void Start()
    {


        Character Player = new Character();
        Player.IsPlayer = true;
        Player.characterName = Console.ReadLine();
        Player.maxHP = 100;

        Character Enemy = new Character();
        Enemy.IsPlayer = false;
        Enemy.maxHP = 15;

        Character.Attack(Player, Enemy);
    }
}
