public class Scripture
{
    private string _text;
    private string _reference;

    private List<string> _words = new List<string>();

    public Scripture(string text, string reference)
    {
        _text = text;
        _reference = reference;
    }

    public List<string> wordList()

    {
        _words = _text.Split(" ").ToList();

        return _words;
    }

}