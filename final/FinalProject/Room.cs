public class Room
{
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public List<Monster> Monsters { get; set; }

    private Hero _hero;

    
    public Room(string description, List<Item> items, List<Monster> monsters, Hero hero)
    {
        _hero = hero;
        Description = description;
        Items = items;
        Monsters = monsters;
    }

    public bool RunRoom()
    {

        int attack = 0;
        Console.WriteLine($"You enter a room. {Description}");

        while (Monsters.Count > 0 && _hero.HitPoints > 0)
        {
            Console.WriteLine("\nWhick monster would you like to attack?");
            foreach (int i in Enumerable.Range(0, Monsters.Count))
            {
                Console.WriteLine($"{i + 1}. {Monsters[i].Name}");
            }
            attack = int.Parse(Console.ReadLine())-1;
            

            Monsters[attack].TakeDamage(_hero.GiveDamage());

            if (Monsters[attack].HitPoints <= 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"\n{Monsters[attack].Name} is dead");
                Monsters.RemoveAt(attack);
            }
            else{
                Console.WriteLine($"\nYou attempt to deal {_hero.GiveDamage()} damage to {Monsters[attack].Name} ");
            }

            foreach (Monster monster in Monsters)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"\n{monster.Name} attempts to deal {monster.GiveDamage()} damage");
                _hero.TakeDamage(monster.GiveDamage());
                Console.WriteLine($"\nYou have {_hero.HitPoints} hit points left");
            }

        }
        if (_hero.HitPoints <= 0)
        {
            return false;
        }
        else
        {
            Console.WriteLine("\nYou win!");
            Thread.Sleep(1000);
            Console.WriteLine("You look around and find that there is:");
            foreach (var item in Items){
                if (item is Weapon)
            {

                Console.WriteLine($"{item.Name} ({item.Description}): Damage {((Weapon)item).Damage}");
            }

            else
            {
                Console.WriteLine($"{item.Name} ({item.Description}): Defence {((Armour)item).Defence}");
            }
            _hero.AddItemToInventory(item);
            }
            Thread.Sleep(1000);
            Console.WriteLine("You pick these up and put them in your inventory");
            _hero.DisplayInventory();

            return true;
        }
    }
}