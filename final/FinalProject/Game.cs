public class Game
{

    Hero _hero;

    public void CreateHero(string name)
    {

        _hero = new Hero(name, 100, 5, 5, 5, 5);

        Console.WriteLine($"Welcome {_hero.Name}!");
        _hero.DisplayStats();
        Console.WriteLine("\n");
        _hero.DisplayEquippedItems();
        Console.WriteLine("\n");
        _hero.DisplayInventory();
        Console.WriteLine("\n");
    }

    public bool FirstRoom()
    {

        string description = "The room is small and dark it contains three small rat looking monsters that attack you.";
        List<Item> items = new List<Item>();
        Weapon dagger = new Weapon("Dagger", 10, "A small and rusty dagger", 10);
        Armour leather = new Armour("Leather Clothes", 20, "A comfortable set of leather clothes", 15);
        items.Add(dagger);
        items.Add(leather);
        List<Monster> monsters = new List<Monster>() { new Monster("Rat", 10, "A small and ugly rat", 7, 5), new Monster("Rat", 10, "A small and ugly rat", 7, 5), new Monster("Rat", 10, "A small and ugly rat", 7, 5) };
        Room room = new Room(description, items, monsters, _hero);
        bool survived = room.RunRoom();

        if (survived)
        {
            Console.WriteLine("You recover 15 hit points");
            _hero.HitPoints += 15;
            Console.WriteLine("You gain 15 experience points");
            _hero.AddExperiencePoints(15);
        }
        return survived;
    }

    public void PlayGame()
    {

        bool survived = FirstRoom();
        if (survived){
        Console.WriteLine("\nWould you like to change your eqiped items? (y/n)");
        string input = Console.ReadLine();
        while (input != "y" && input != "n")
        {
            Console.WriteLine("Please enter y or n");
            input = Console.ReadLine();
        }

        if (input == "y")
        {
            _hero.EquipItem();
        }

        _hero.DisplayStats();
        _hero.DisplayEquippedItems();
        }
        else{
            Console.WriteLine("Game Over");
        }

    }

}