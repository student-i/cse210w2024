public class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon(string name, int value, string description, int damage) :
    base(name, value, description)
    {
        Damage = damage;
    }
}