using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

public class Word
{
    Scripture _scripture;

    private List<string> _wordList = new List<string>();

    private List<string> _displayWords = new List<string>();

    Random ran = new Random();

    public Word(string verse, string book)
    {
        _scripture = new Scripture(verse, book);

    }

    public void RanWord()
    {

        bool done = false;

        while (!done)
        {

            int index = ran.Next(_wordList.Count);

            if (_wordList[index] != "alreadyHidden")
            {
                _displayWords[index] = new string('_', _wordList[index].Length);
                _wordList[index] = new string("alreadyHidden");
                done = true;
            }
        }
    }

    public void GetWords()
    {
        _wordList = _scripture.WordList();
        _displayWords = _scripture.WordList();
    }

    public void Display()
    {
        bool learning = true;
        while (learning)
        {

            Console.Clear();
            Console.WriteLine(_scripture.GetBook());
            Console.WriteLine(string.Join(" ", _displayWords));

            Console.Write("Hit enter to continue or q to quit: ");
            string input = Console.ReadLine();
            if (input == "q")
            {
                learning = false;
            }
            else if (IsComplete()) {

                learning = false;
            }
            else
            {
                RanWord();
            }
        }

    }

    public bool IsComplete()
    {

        foreach (string word in _wordList)
        {
            if (word != "alreadyHidden" && word != "\n")
            {
                return false;
            }
        }

        return true;
    }


}