using System;

public class Game
{
    public void runGame()
    {
        AstroShip astro = new AstroShip();
        StellarShip stellar = new StellarShip();

        bool stellarShipHasWon = stellar.HasWon();
        bool astroShipHasWon = astro.HasWon();



        while (!astro.HasWon() && !stellar.HasWon())
        {
            stellar.Move();
            astro.Move();
        }

        if (astro.HasWon() && stellar.HasWon())
            Console.WriteLine("Draw");

        else
        {

            if (astro.HasWon())
                Console.WriteLine("Astro");

            else if (stellar.HasWon())
                Console.WriteLine("Stellar");


        }
    }
}
