using System;

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

    public void Attack(Character attacked)
    {


        Console.WriteLine("Attacking enemy");

        attacked.maxHP -= 2;
        maxHP--;
        Console.WriteLine(attacked.maxHP);
        Console.WriteLine(maxHP);
        
    }

}
