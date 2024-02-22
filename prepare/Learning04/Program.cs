using System;

class Program
{
    static void Main(string[] args)
    {




        Assignment assignment = new Assignment("Emily Johnson", "WW2");
        Console.WriteLine(assignment.getSummary());



        mathAssignment math = new mathAssignment("Aura River", "Algebra", "45.9", "These are supposed to be the problems");

        Console.WriteLine(math.getSummary());
        Console.WriteLine(math.getHomeworkList());



        writeingAssignment write = new writeingAssignment("Daisy Echo ", "Birds", "The life of a bird");
        Console.WriteLine(write.getSummary()); 
        Console.WriteLine(write.getWritingInformation());


    }
}