using System.Runtime.CompilerServices;

public class Hero : Entity
{

    public List<Item> Inventory = new List<Item> { };

    public int ExperiencePoints { get; set; }

    public List<Item> CurrentlyEquipped = new List<Item> { };


    public int Gold { get; set; }

    public Hero(string name, int hitPoints, int attack, int personalDefence, int experiencePoints, int gold) :
    base(name, hitPoints, attack, personalDefence)
    {
        ExperiencePoints = experiencePoints;
        Gold = gold;
        CurrentlyEquipped.Add(new Armour("Plain clothes", 10, "What you normaly wear", 0));
        CurrentlyEquipped.Add(new Weapon("Stick", 1, "A stick you found on the ground", 5));
    }

    public override void TakeDamage(int damageTaken)
    {
        int currentDefence = PersonalDefence;
        foreach (var item in CurrentlyEquipped)
        {

            if (item is Armour)
            {

                currentDefence += ((Armour)item).Defence;
            }
        }

        int potentialDamage = damageTaken - currentDefence;
        if (potentialDamage > 0)
        {

            HitPoints -= potentialDamage;
        }



    }

    public override int GiveDamage()
    {
        int currentAttack = Attack;
        foreach (var item in CurrentlyEquipped)
        {

            if (item is Weapon)
            {

                currentAttack += ((Weapon)item).Damage;
            }
        }
        return currentAttack;
    }

    public void DisplayInventory()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Inventory:");
        if (Inventory.Count == 0)
        {
            Console.WriteLine("You don't have any items!");
        }
        foreach (var item in Inventory)
        {

            if (item is Weapon)
            {

                Console.WriteLine($"{item.Name}: Damage {((Weapon)item).Damage}");
            }

            else
            {
                Console.WriteLine($"{item.Name}: Defence {((Armour)item).Defence}");
            }
        }
        Thread.Sleep(1000);
    }

    public void AddItemToInventory(Item item)
    {
        Inventory.Add(item);
    }

    public void EquipItem()
    {

        string exchange = "y";

        while (exchange == "y")
        {

            DisplayInventory();

            if (Inventory.Count == 0)
            {
                Console.WriteLine("You don't have any items to equip!");
            }
            else
            {

                string toAdd = "";
                Item itemToEquip = null;
                do
                {
                    Console.Write("Which item would you like to equip? ");
                    toAdd = Console.ReadLine();
                    itemToEquip = Inventory.FirstOrDefault(item => item.Name == toAdd);
                }
                while (itemToEquip == null);


                for (int index = 0; index < Inventory.Count; index++)
                {

                    int i = Inventory.IndexOf(itemToEquip);

                    if (itemToEquip is Weapon)
                    {

                        if (CurrentlyEquipped[index] is Weapon)
                        {
                            Inventory[i] = CurrentlyEquipped[index];
                            CurrentlyEquipped[index] = itemToEquip;
                        }
                    }
                    if (itemToEquip is Armour)
                    {


                        if (CurrentlyEquipped[index] is Armour)
                        {
                            Inventory[i] = CurrentlyEquipped[index];
                            CurrentlyEquipped[index] = itemToEquip;

                        }
                    }
                }

            }
            Console.WriteLine($"Item equipped!");
            Console.Write("Would you like to equip another item? (y/n) ");
            exchange = Console.ReadLine();
            while (exchange != "y" && exchange != "n")
            {
                Console.Write("Please enter y or n: ");
                exchange = Console.ReadLine();
            }
        }
    }

    public void DisplayEquippedItems()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Currently equipped:");
        foreach (var item in CurrentlyEquipped)
        {

            if (item is Weapon)
            {

                Console.WriteLine($"{item.Name} ({item.Description}): Damage {((Weapon)item).Damage}");
            }

            else
            {
                Console.WriteLine($"{item.Name} ({item.Description}): Defence {((Armour)item).Defence}");
            }
        }
        Thread.Sleep(1000);
    }

    public void AddHitPoints(int hitPointsToAdd)
    {
        HitPoints += hitPointsToAdd;
    }

    public void DisplayStats()
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Your stats are: ");
        Console.WriteLine($"{HitPoints} hit points");
        // Console.WriteLine($"{Attack} attack");
        // Console.WriteLine($"{PersonalDefence} defence");
        Console.WriteLine($"{ExperiencePoints} experience points");
        Console.WriteLine($"{Gold} gold");
        Thread.Sleep(1000);
    }

    public void AddExperiencePoints(int experiencePointsToAdd)
    {
        ExperiencePoints += experiencePointsToAdd;
    }
}





