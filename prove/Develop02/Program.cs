using System;


// set variables
string userChoice = "1";
Entry entry = new Entry();
Journal journal = new Journal();


string newEntry = ("No entries");
Console.WriteLine("Welcome to your journal!");

Console.Write("What is the name of your file?");
string _fileName = Console.ReadLine();

while (userChoice != "5")
{
    // menu
    Console.WriteLine("Please select one of the following one of the follwing:");
    Console.Write("1. Write\n2. Display\n3. Load Past Entries\n4. Save\n5. Quit\n>");

    

    userChoice = Console.ReadLine();

    switch (userChoice)
    {

        // write in the journal
        case "1":
            newEntry = entry.GetUserEntry();
            entry._entries.Add(newEntry);
            
            break;
        case "2":

        // display recent entry
            foreach(string e in entry._entries ){
                Console.WriteLine(e);
            }
            break;
        case "3":
        
        // load the journal
            journal.LoadJournal(_fileName);
            break;

        case "4":

            // save the recent entry
            journal.SaveEntry(entry._entries,_fileName);
            Console.WriteLine("Your entry has been saved");
            break;
        case "5":

            // end the program
            break;
        default:

            // errors
            Console.WriteLine("Please enter a number from the menu.");
            break;
    }
}
Console.WriteLine("Thank you for using the journal app.");
