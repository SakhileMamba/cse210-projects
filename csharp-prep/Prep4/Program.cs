using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbersList = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbersList.Add(number);
            }
        } while (number != 0);

        int sum = 0;


        foreach (int member in numbersList)
        {
            sum = sum + member;
        }

        float average = sum / float.Parse(numbersList.Count().ToString());

        int largestNumber = 0;

        foreach (int member in numbersList)
        {
            if (member > largestNumber)
            {
                largestNumber = member;
            }
        }


        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");


        //Console.WriteLine($"The sum is: {numbersList.Sum()}");
        //Console.WriteLine($"The average is: {numbersList.Average()}");
        //Console.WriteLine($"The largest number is: {numbersList.Max()}");

        /*
        Stretch exercise part 1
        List<int> positiveNumbers = new List<int>();

        foreach (int member in numbersList)
        {
            if (member >= 0)
            {
                positiveNumbers.Add(member);
            }
        }

        Console.WriteLine($"The smallest positive number is: {positiveNumbers.Min()}");
        */
    }
}