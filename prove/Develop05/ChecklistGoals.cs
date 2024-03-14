public class ChecklistGoals : Goal
{
    public ChecklistGoals(List<string> goals, int totalPoints) : base(goals, totalPoints)
    {

    }

    public override void AddGoal(string type)
    {
        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();

        Console.Write("What is the number of points for maintaining this goal?");
        int points = int.Parse(Console.ReadLine());

        Console.Write("What is the ammount of points for when the goal is completed?");
        int final = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished before completing?");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add($"checklist,{name},{description},{points},[ ],{final},{bonus},{0}");

    }

    public override void RecordEvent(int index)
    {

        string adjust = _goals[index];
        string[] partAdjust = adjust.Split(",");

        int tillComplete = int.Parse(partAdjust[7]);
        tillComplete++;
        partAdjust[7] = tillComplete.ToString();

        if (partAdjust[7] == partAdjust[6])
        {

            AddPoints(int.Parse(partAdjust[5]));
            partAdjust[4] = "[x]";
        }
        else
        {

            AddPoints(int.Parse(partAdjust[3]));
        }

        _goals[index] = string.Join(",", partAdjust);
    }
}