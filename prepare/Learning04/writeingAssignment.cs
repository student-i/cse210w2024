public class writeingAssignment : Assignment
{
    private string _title;

    public writeingAssignment(string studentName, string topic, string title) :
    base(studentName, topic)
    {

        _title = title;
    }

    public string getWritingInformation()
    {


        string name = getStudentName();
        return ($"{_title} by {name}");
    }

}