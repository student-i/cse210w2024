public class Assignment
{
    private string _studentName;

    private string _topic;



    public Assignment(string studentName, string topic)
    {

        _studentName = studentName;
        _topic = topic;

    }

    public string getStudentName()
    {
        return _studentName;
    }

    public string getTopic()
    {
        return _topic;
    }
    public string getSummary()
    {

        return ($"{_studentName} - {_topic}");

    }



}