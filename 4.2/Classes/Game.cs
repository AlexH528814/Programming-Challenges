using System;

public class Game
{
    public void Start()
    {

        string playerName = "player";


        Character Player = new Character(playerName, 3, true);


        Character Enemy = new Character("Luka", 2, false);



        Player.Attack(Enemy);
        Enemy.Attack(Player);
    }
}
