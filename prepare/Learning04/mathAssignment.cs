

public class mathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public mathAssignment(string studentName, string topic, string textbookSection,
    string problems) : base(studentName, topic)
    {

        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string getHomeworkList()
    {


        return ($"{_textbookSection} - {_problems}");
    }

}