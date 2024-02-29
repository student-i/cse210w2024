using System;

class Program
{
    static void Main(string[] args)
    {

        string type;
        string description;
        string choice = "unused";

        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    type = "Breathing";
                    description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathing = new BreathingActivity(type, description);
                    breathing.runBreathing();
                    break;

                case "2":

                    type = "Reflection";
                    description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectionActivity reflection = new ReflectionActivity(type, description);
                    reflection.runReflection();
                    break;

                case "3":

                    type = "Listing";
                    description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity listing = new ListingActivity(type, description);
                    listing.runListing();
                    break;

                case "4":

                    Console.WriteLine("Goodbye!");
                    Console.Clear();
                    break;
                
                default:

                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.Clear();
                    break;



            }

        }

    }
}