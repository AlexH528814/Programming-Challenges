using System;

public class Ship
{
    internal string shipname;
    internal int currentpos = 0;
    internal int movementspeed = 2;

    internal void Move()
    {      
            currentpos += movementspeed;
            Console.WriteLine($"Ship is {currentpos} distance from start");
    }
}
