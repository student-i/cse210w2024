using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Refrence refrence = new Refrence();
        refrence.AddRefrence("John 3:16", "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Write("What is the refrence? ");
        string re = ("John 3:16");
        string run = refrence.findRefrence(re);
        Console.WriteLine($"Find a refrence: {re}");


        Scripture scripture = new Scripture(run,re);
        
        Word word = new Word(scripture);

        word.getWords();

        word.display();
    }
}