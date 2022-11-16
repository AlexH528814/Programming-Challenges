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

        Console.WriteLine(characterName);
    }

    public void Attack(Character attacked)
    {
        attacked.maxHP--;
        maxHP--;
        Console.WriteLine("Attacked");
    }

}
