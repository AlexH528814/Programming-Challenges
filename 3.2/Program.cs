using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.ConstrainedExecution;



class Program
{
    static void Main()
    {
        Game game = new Game();

        game.Start();
        Environment.Exit(0);
    }
}