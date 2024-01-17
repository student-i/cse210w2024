using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        int addNumber = 3;

        while (addNumber != 0){

        Console.Write("What number do you want to add? ");
        addNumber = int.Parse(Console.ReadLine());
        
        if (addNumber != 0){
            numbers.Add(addNumber);
        }

    }

    int total = 0;
    int biggest = 0;
    int smallestPositive = 1000000000;

    foreach(int number in numbers){
        total += number;
        if (number > biggest){
            biggest = number;
        }
        if (number < smallestPositive && number > 0){
            smallestPositive = number;
        }
        
    }

    Console.WriteLine($"Sum: {total}");
    Console.WriteLine($"Average: {total/numbers.Count}");
    Console.WriteLine($"Biggest number: {biggest}");
    Console.WriteLine($"Smallest positive number: {smallestPositive}");
    
        }
}