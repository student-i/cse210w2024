public class Item
{
    public string Name { get; set; }
    public int Value { get; set; }
    public string Description { get; set; }

    public Item(string name, int value, string description){

        Name = name;
        Value = value;
        Description = description;
    }
}