using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        Game game = new Game();
        Console.WriteLine("Enter the name of your hero: ");
        Console.Write("> ");
        name = Console.ReadLine();
        game.CreateHero(name);
        game.PlayGame();
    }
}