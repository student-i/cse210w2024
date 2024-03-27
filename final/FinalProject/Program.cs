using System;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.CreateHero("Lucky");
        game.PlayGame();
    }
}