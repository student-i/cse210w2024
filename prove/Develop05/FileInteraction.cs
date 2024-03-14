using System.Drawing;

public class FileInteraction
{
    private string _fileName = "";
    private List<string> _goals = new List<string>();

    int _points = 0;


    public FileInteraction(string filename)
    {

        _fileName = "goals.txt";

    }

    public void ReadFile()
    {

        _goals.AddRange(File.ReadAllLines(_fileName));


        string pointsLine = _goals[_goals.Count - 1];
        string[] parts = pointsLine.Split(",");
        _points = int.Parse(parts[1]);
        _goals.Remove(pointsLine);

    }

    public void WriteFile(List<string> newGoals)
    {
        File.WriteAllLines(_fileName, newGoals);

    }

    public List<string> GetGoalList()
    {
        return _goals;
    }
    public int GetPoints()
    {
        return _points;
    }

}