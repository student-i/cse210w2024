public class SimpleGoal : Goal
{
    public SimpleGoal(List<string> goals, int totalPoints) : base(goals, totalPoints)
    {

    }

    public override void AddGoal(string type)
    {
        base.AddGoal("simple");
    }

    public override void RecordEvent(int index)
    {
        base.RecordEvent(index);
    }
}