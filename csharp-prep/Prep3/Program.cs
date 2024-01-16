using System;

class Program
{
    static void Main(string[] args)
    {
     
        string playAgain = "yes";
        while (playAgain == "yes"){

        int NumberOfGuesses = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 2000;

        while (guess != magicNumber){

            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            NumberOfGuesses ++;
            if (guess > magicNumber){

                Console.WriteLine("Lower");
            }
            else{

                Console.WriteLine("Higher");
            }

        }

        Console.WriteLine("You are right.");
        Console.WriteLine($"You took {NumberOfGuesses} guesses.");
        Console.Write("Would you like to play again? yes/no ");
        playAgain = Console.ReadLine();
    }
        }
}