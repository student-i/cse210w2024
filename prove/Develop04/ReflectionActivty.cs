using System.Globalization;

public class ReflectionActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = new string[]{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<int> _usedQuestions = new List<int>();
    private List<int> _usedPrompts = new List<int>();

    public ReflectionActivity(string type, string description) : base(type, description)
    {
    }
    public string getPrompt()
    {
        Random ran = new Random();
        if (_usedPrompts.Count == _prompts.Length)
        {
            _usedPrompts.Clear();
        }

        int _index;
        do
        {
            _index = ran.Next(_prompts.Length);
        } while (_usedPrompts.Contains(_index));

        _usedPrompts.Add(_index);
        return _prompts[_index];
    }

    public string getQuestion()
    {
        Random ran = new Random();

        if (_usedQuestions.Count == _questions.Length)
        {
            _usedQuestions.Clear();
        }

        int _index;
        do
        {
            _index = ran.Next(_questions.Length);
        } while (_usedQuestions.Contains(_index));

        _usedQuestions.Add(_index);
        return _questions[_index];
    }

    public void runReflection()
    {

        Start();
        Thread.Sleep(700);
        Console.Write("Get ready...");
        Spinner();

        Task delayTask = Task.Delay(TimeSpan.FromSeconds(Getduration()));

        while (!delayTask.IsCompleted)
        {

            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($"\n--- {getPrompt()} ---");
            Thread.Sleep(700);
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in:");
            CountDown(3);

            while (!delayTask.IsCompleted)
            {
                Console.Write($"{getQuestion()}");
                Spinner();
                Console.WriteLine("\n");
            }

        }
        EndActivty();
    }
}

