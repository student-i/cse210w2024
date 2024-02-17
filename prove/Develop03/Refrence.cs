using System.ComponentModel;

public class Refrence
{
    private List<string> _keys = new List<string>();

    private List<string> _values = new List<string>();


    public void AddRefrence(string key, string value)
    {
        _keys.Add(key);
        _values.Add(value);
    }

    public string FindRefrence(int index, string type)
    {

        if (type == "text")
        {
            return _values[index];
        }

        else

            return _keys[index];

    }
    public int RanRefrence()
    {
        Random ran = new Random();

        int randomIndex = ran.Next(_keys.Count);

        return randomIndex;
    }

}