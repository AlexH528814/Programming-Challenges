using System;

public class Game
{
    public void runGame()
    {
        AstroShip astro = new AstroShip();
        StellarShip stellar = new StellarShip();
       
        while (stellar.currentpos < 100 && astro.currentpos < 100)
        {
            stellar.Move();
            astro.Move();
        }
      


    }
}
