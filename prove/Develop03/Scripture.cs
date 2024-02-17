public class Scripture
{
    private string _verse;
    private string _book;

    private List<string> _words = new List<string>();

    public Scripture(string verse, string book)
    {
        _verse = verse;
        _book = book;
    }

    public List<string> WordList()

    {
        _words = _verse.Split(" ").ToList();

        return _words;
    }

    public string GetBook()
    {
        return _book;
    }


}