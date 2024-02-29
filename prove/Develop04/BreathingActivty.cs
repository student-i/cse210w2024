using System.Reflection.PortableExecutable;

public class BreathingActivity : Activity
{

    public BreathingActivity(string type, string description) :
     base(type, description)
    {

    }

    public void runBreathing()
    {

        Start();
        Thread.Sleep(700);
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
        Thread.Sleep(700);
        Console.Write("Start in . .");
        CountDown(3);
        for (int n = Getduration(); n > 0; n -= 10)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in...");
            CountDown(4);
            Console.Write("Breathe out...");
            CountDown(6);
        }

        EndActivty();
    }
}
