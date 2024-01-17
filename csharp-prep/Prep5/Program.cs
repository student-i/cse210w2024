using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string name = PromptUserName();

        int number = PromptUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name,square); 

        Console.WriteLine($"");
    }

    static string PromptUserName(){

        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber(){

        Console.Write("What is your number? ");
        int number = int.Parse(Console.ReadLine());

        return number;

    }

    static int SquareNumber(int number){

        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square){

        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}