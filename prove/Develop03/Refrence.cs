using System.ComponentModel;

public class Refrence
{
    private KeyValuePair<string, string> _refrences = new KeyValuePair<string, string>();


    public void AddRefrence(string key, string value)
    {
        _refrences = new KeyValuePair<string, string>(key, value);
    }

    public string findRefrence(string key)
    {
        return _refrences.Value;
    }

}