using System.ComponentModel.DataAnnotations;


public class Goal
{
    private int _totalPoints;

    protected List<string> _goals = new List<string>();

    public Goal(List<string> goals, int totalPoints)
    {

        _goals = goals;
        _totalPoints = totalPoints;
    }

    public void AddPoints(int points)
    {

        _totalPoints += points;
    }

    public void DisplayGoal()
    {

        foreach (string goal in _goals)
        {

            string[] parts = goal.Split(",");
            if (parts[0] == "checklist")
            {

                Console.WriteLine($"{parts[4]} {parts[1]}: {parts[2]} ({parts[3]} points) {parts[7]}/{parts[6]}");
            }
            else
            {
                Console.WriteLine($"{parts[4]} {parts[1]}: {parts[2]} ({parts[3]} points)");
            }
        }


        Console.WriteLine($"Total points: {_totalPoints}");

    }

    public virtual void AddGoal(string type)
    {

        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        _goals.Add($"{type},{name},{description},{points},[ ]");
    }

    public virtual void RecordEvent(int index)
    {

        string adjust = _goals[index];
        string[] partAdjust = adjust.Split(",");

        partAdjust[4] = "[x]";

        AddPoints(int.Parse(partAdjust[3]));

        _goals[index] = string.Join(",", partAdjust);
    }

    public int GetCurrentPoints()
    {

        Console.WriteLine($"Total points: {_totalPoints}");

        return _totalPoints;
    }

    public bool DidLevelUp(int i, int currentPoints)
    {
        string check = _goals[i];
        string[] parts = check.Split(",");
        int oldPoints = currentPoints - int.Parse(parts[3]);
        if (oldPoints < 50 && currentPoints >= 50)
        {
            return true;
        }
        else if (oldPoints <= 500 && currentPoints > 500)
        {
            return true;
        }
        else if (oldPoints <= 1500 && currentPoints > 1500)
        {
            return true;
        }
        else if (oldPoints <= 3000 && currentPoints > 3000)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}