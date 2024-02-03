

using System.ComponentModel;

public class Entry{
    PromptGeneration _promptGen = new PromptGeneration();
    public string _entry;

    // list of entries
    public List<string> _entries = new List<string>();

    // todays date
    string _todaysDate = DateTime.Now.ToString("M/d/yyyy");

    public string GetUserEntry(){

        // get a random prompt
        string _promptForEntry = _promptGen.GetRandomPrompt();

        // get an entry
        Console.WriteLine("For each enrty you get a random prompt.");
        Console.Write("The prompt for this entry is: ");
        Console.WriteLine(_promptForEntry);

        Console.Write("Your Entry: ");
        _entry = Console.ReadLine();
        
        // return the entry
        return ($"Date {_todaysDate} Prompt: {_promptForEntry} \n{_entry}\n");
    }
}