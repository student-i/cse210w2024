public class Armour : Item
{
    public int Defence { get; set; }

    public Armour(string name, int value, string description, int defence) 
    : base(name, value, description){

        Defence = defence;
    }
}