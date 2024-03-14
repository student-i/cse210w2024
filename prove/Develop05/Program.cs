

using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {

        bool levelUp = false;
        string[] titles = { "Beginner", "Barley Started Mouse", "Really Getting Going Dog", "Almost a Master Bear", "Expert Unicorn" };
        List<string> _goals = new List<string>();
        string filename;
        int _totalPoints = 0;

        string choice = "n";

        Console.WriteLine("Welcome to the Goal Tracker!");


        while (choice != "6")
        {
            int i;
            Console.WriteLine("\n");
            if (levelUp == true)
            {
                Console.WriteLine("LEVEL UP!");
                levelUp = false;
            }
            if (_totalPoints < 50)
            {
                i = 0;
            }
            else if (_totalPoints <= 500)
            {
                i = 1;
            }
            else if (_totalPoints <= 1500)
            {
                i = 2;
            }
            else if (_totalPoints <= 3000)
            {
                i = 3;
            }
            else
            {
                i = 4;
            }

            Console.WriteLine($"You are a {titles[i]} with");
            Console.WriteLine($"\nAmmount of points: {_totalPoints}\n");

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
                            simpleGoal.AddGoal(goalType);

                            break;

                        case "2":

                            EternalGoals eternalGoals = new EternalGoals(_goals, _totalPoints);
                            eternalGoals.AddGoal(goalType);

                            break;

                        case "3":

                            ChecklistGoals checklistGoals = new ChecklistGoals(_goals, _totalPoints);
                            checklistGoals.AddGoal(goalType);

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
                    int num = 1;
                    foreach (string item in _goals)
                    {

                        string[] part = item.Split(",");
                        Console.WriteLine($"{num}. {part[1]}");
                        num++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int goalNum = int.Parse(Console.ReadLine()) - 1;

                    string[] parts = _goals[goalNum].Split(",");
                    if (parts[0] == "checklist")
                    {

                        ChecklistGoals checklistGoals = new ChecklistGoals(_goals, _totalPoints);
                        checklistGoals.RecordEvent(goalNum);
                        _totalPoints = checklistGoals.GetCurrentPoints();

                    }
                    else if (parts[0] == "eternal")
                    {
                        EternalGoals eternalGoals = new EternalGoals(_goals, _totalPoints);
                        eternalGoals.RecordEvent(goalNum);
                        _totalPoints = eternalGoals.GetCurrentPoints();

                    }
                    else if (parts[0] == "simple")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(_goals, _totalPoints);
                        simpleGoal.RecordEvent(goalNum);
                        _totalPoints = simpleGoal.GetCurrentPoints();

                    }
                    Goal lGoal = new Goal(_goals, _totalPoints);
                    levelUp = lGoal.DidLevelUp(goalNum, _totalPoints);
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