public abstract class Entity
{
    public string Name { get; set; }
    public int HitPoints { get; set; }

    public int Attack { get; set; }
    public int PersonalDefence { get; set; }

    public Entity(string name, int hitPoints, int attack, int defence)
    {
        Attack = attack;
        PersonalDefence = defence;

        Name = name;
        HitPoints = hitPoints;
    }

    public abstract void TakeDamage(int damageTaken);

    public abstract int GiveDamage();
        
}