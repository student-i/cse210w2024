using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

public class Word
{
    Scripture _scripture;

    private string _title;

    private string _text;
    private List<string> _wordList = new List<string>();

    private List<string> _displayWords = new List<string>();

    Random ran = new Random();

    public Word(Scripture scripture)
    {
        _scripture = scripture;
        
    }

    public void ranWord()
    {

        bool done = false;

        while (!done)
        {

            int index = ran.Next(_wordList.Count);

            if (_wordList[index] != "used")
            {
                _wordList[index] = new string("used");
                _displayWords[index] = new string('_', _wordList[index].Length);
                done = true;
            }
        }
    }

    public void getWords()
    {

        _wordList = _scripture.wordList();
        _displayWords = _scripture.wordList();

    }

    public void display()
    {
        bool learning = true;
        while (learning)
        {

            Console.WriteLine(_title);
            Console.WriteLine(string.Join(" ", _displayWords));

            Console.Write("Hit enter to continue or q to quit: ");
            string input = Console.ReadLine();
            if (input == "q")
            {
                learning = false;
            }

            else if (IsComplete())
            {
                learning = false;
            }
            else
            {
                ranWord();
            }
        }

    }

    public bool IsComplete()
    {

        foreach (string word in _wordList)
        {
            if (word != "used")
            {
                return false;
            }
        }

        return true;
    }
}