using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Refrence refrence = new Refrence();
        refrence.AddRefrence("John 3:16", "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        refrence.AddRefrence("D&C 43:6", "And this I give unto you that you may not be deceived, that you may know they are not of me.");

        refrence.AddRefrence("3 Nephi 9:21", "Behold, I have come unto the world to bring redemption unto the world, to save the world from sin.");


        char again = 'y';

        while (again == 'y')
        {
            Console.Clear();
            Console.Write("Would you like to ADD a new scripture or get a RANDOM scripture? ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "RANDOM")
            {


                int index = refrence.RanRefrence();


                string type = "text";
                string text = refrence.FindRefrence(index, type);

                type = "scrip";
                string scrip = refrence.FindRefrence(index, type);


                Word word = new Word(text, scrip);

                word.GetWords();

                word.Display();

                Console.WriteLine("Would you like to get another scripture? y/n");
                again = Console.ReadLine()[0];
            }
            else if (input.ToUpper() == "ADD")
            {

                Console.Write("Enter the book and verse(s): ");
                string book = Console.ReadLine();

                char more = 'y';


                List<string> verses = new List<string>();
                while (more == 'y')
                {

                    Console.Write("Enter the verse: ");
                    string var = Console.ReadLine();
                    verses.Add(var);
                    Console.Write("Is there another verse? y/n ");
                    more = Console.ReadLine()[0];
                }
                string verse = ("");
                foreach (string v in verses)
                {
                    verse = ($"{verse}\n{v} ");
                }

                refrence.AddRefrence(book, verse);

                Word word = new Word(verse, book);

                word.GetWords();

                word.Display();

                Console.WriteLine("Would you like to get another scripture? y/n");
                again = Console.ReadLine()[0];

            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        Console.WriteLine("Goodbye!");
    }
}