using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string user_input = Console.ReadLine();
        int percentage = int.Parse(user_input);
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        if (!(percentage > 100 || letter == "F"))
        {
            while (percentage > 9)
            {
                percentage -= 10;
            }

            if (percentage >= 7)
            {
                sign = "+";
            }
            else if (percentage <= 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You have failed the class.");
        }
        else
        {
            Console.WriteLine("You passed the class!!");
        }




    }
}