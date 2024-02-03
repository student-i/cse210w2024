
using System.Reflection.Metadata;

public class PromptGeneration{

    // list of prompts
    public string[] _prompts = new string[]
    {"What happened today?",
    "What was the best thing that happened today?", 
    "What was the worst thing that happened today?",
    "What was the most interesting thing I saw or heard today?",
    "What was the most challenging thing I faced today?",
    "What am I grateful for today?",
    "What did I learn today?",
    "What was the most fun thing I did today?",
    "What was the most surprising thing that happened today?",
    "What did I do today that I am proud of?"};

    public List <int> _usedPrompts = new List<int>();


        public string GetRandomPrompt()
    {
        Random rand = new Random();
        if (_usedPrompts.Count == _prompts.Length)
        {
            _usedPrompts.Clear(); // Reset if all prompts have been used
        }

        int _index;
        do
        {
            _index = rand.Next(_prompts.Length);
        } while (_usedPrompts.Contains(_index));

        _usedPrompts.Add(_index);
        return _prompts[_index];
    }
}