

using System.Xml;

public class Journal{

    
    // file name, can be changed
    
    
    public void SaveEntry(List <string> entries, string _fileName)
    {

        // add the entries to the journal
        foreach (string e in entries)
        File.AppendAllText(_fileName, e + "\n");

        entries.Clear();
        
    }

    public void LoadJournal(string _fileName)
    { 
        // load the journal
        Console.WriteLine(File.ReadAllText(_fileName));
    }
    
}
