using System.ComponentModel.DataAnnotations;

public class Goal
{
    private int _totalPoints;

    private List<string> _goals = new List<string>();

    public Goal(List<string> goals, int totalPoints){

        _goals = goals;
        _totalPoints = totalPoints;
    }

    public void AddPoints(int points){
        
        _totalPoints += points;
    }

    public void DisplayGoal(){

        foreach (string goal in _goals)
        {

        string[] parts = goal.Split(",");

        Console.WriteLine($"{parts[1]}: {parts[2]} ({parts[3]} points)");
        }
    }
}