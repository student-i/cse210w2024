using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};

    private List<string> _userList = new List<string>();

    private List<int> _usedPrompts = new List<int>();


    public ListingActivity(string type, string description) :
    base(type, description)
    {

    }

    public string GetPrompt()
    {

        Random ran = new Random();

        if (_usedPrompts.Count == _prompts.Length)
        {
            _usedPrompts.Clear(); // Reset if all prompts have been used
        }

        int _index;
        do
        {
            _index = ran.Next(_prompts.Length);
        } while (_usedPrompts.Contains(_index));

        _usedPrompts.Add(_index);
        return _prompts[_index];
    }

    public void AddUser(string userinput)
    {

        _userList.Add(userinput);

    }

    public void DisplayList()
    {
        foreach (string item in _userList)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }

    public void RunListing()
    {

        Start();
        Thread.Sleep(700);
        Console.WriteLine("Get ready...");
        Spinner();
        Thread.Sleep(700);
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine($"--- {GetPrompt()} ---");
        Thread.Sleep(700);
        Console.Write("You may begin in: ");
        CountDown(3);



        Task delayTask = Task.Delay(TimeSpan.FromSeconds(Getduration()));

        while (!delayTask.IsCompleted)
        {
            Console.Write(">");
            AddUser(Console.ReadLine());
        }

        Console.Clear();
        DisplayList();
        EndActivty();


    }

}