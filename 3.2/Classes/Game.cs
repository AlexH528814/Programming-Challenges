using System;

public class Game
{
    public void Start()
    {


        Character Player = new Character(Console.ReadLine(), 3, true);
        

        Character Enemy = new Character("Luka", 2, false);
        


        Player.Attack(Player);
    }
}
