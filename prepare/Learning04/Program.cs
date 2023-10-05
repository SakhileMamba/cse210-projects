using System;

class Program
{
    static void Main(string[] args)
    {   
        Assignment assignment1 = new Assignment("Sakhile Mamba", "Some Topic");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();
        
        // Now create the derived class assignments
        MathAssignment assignment2 = new MathAssignment("Sakhile Mamba", "Division", "10.3", "1-2");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Sakhile Mamba", "English", "The world is falling apart!");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();
    }
}