public class EternalGoals : Goal
{
    public EternalGoals(List<string> goals, int totalPoints) : base(goals, totalPoints)
    {

    }

    public override void AddGoal(string type)
    {
        base.AddGoal("eternal");

    }

    public override void RecordEvent(int index)
    {
        string adjust = _goals[index];
        string[] partAdjust = adjust.Split(",");
        AddPoints(int.Parse(partAdjust[3]));
    }

}