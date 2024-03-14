using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        List<string> _goals = new List<string>();
        string filename;
        int _totalPoints = 0;

        string choice = "n";

        Console.WriteLine("Welcome to the Goal Tracker!");

        while (choice != "6")
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();


            switch (choice)
            {

                case "1":

                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType)
                    {
                        case "1":

                            SimpleGoal simpleGoal = new SimpleGoal(_goals, _totalPoints);
                            break;

                        case "2":

                            EternalGoals eternalGoals = new EternalGoals(_goals, _totalPoints);
                            break;

                        case "3":

                            ChecklistGoals checklistGoals = new ChecklistGoals(_goals, _totalPoints);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    break;

                case "2":

                    Goal goal = new Goal(_goals, _totalPoints);
                    goal.DisplayGoal();

                    break;

                case "3":
                    Console.Write("What is the name of your goal file? ");
                    filename = Console.ReadLine();

                    _goals.Add($"points,{_totalPoints}");
                    FileInteraction saveFile = new FileInteraction(filename);
                    saveFile.WriteFile(_goals);

                    break;

                case "4":
                    Console.Write("What is the name of your goal file? ");
                    filename = Console.ReadLine();
                    FileInteraction file = new FileInteraction(filename);

                    file.ReadFile();
                    _goals = file.GetGoalList();
                    _totalPoints = file.GetPoints();

                    break;

                case "5":

                    break;

                case "6":

                    Console.WriteLine("Goodbye!");
                    break;

                default:

                    Console.WriteLine("Invalid choice. Please try again.");
                    break;


            }


        }


    }
}