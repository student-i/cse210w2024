public class Activity
{
    private int _activityDuration;

    private List<string> _spinner = new List<string> { "/", "-", "\\", "|" };
    private string _type;

    private string _description;

    public Activity(string type, string description)
    {

        _type = type;

        _description = description;

    }

    public void Start()
    {
        Console.Clear();
        Thread.Sleep(700);
        Console.WriteLine($"Welcome to the {_type} Activity.\n");

        Thread.Sleep(700);
        Console.WriteLine(_description);

        Thread.Sleep(700);
        Console.Write("\nHow many seconds would you like it to last? ");


        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void CountDown(int ammount)
    {
        for (int n = ammount; n > 0; n--)
        {

            Console.Write(n);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void Spinner()
    {

        for (int n = 5; n > 0; n--)
        {

            foreach (string symbol in _spinner)
            {
                Console.Write(symbol);
                Thread.Sleep(500);
                Console.Write("\b \b");

            }

        }
    }

    public void EndActivty()
    {

        Thread.Sleep(700);
        Console.WriteLine("\nWell Done!");
        Thread.Sleep(700);
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_type} activity");
        Console.ReadLine();
        Console.Clear();
    }

    public int Getduration()
    {
        return _activityDuration;
    }
}