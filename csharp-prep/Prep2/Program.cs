using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();

        int value = int.Parse(percentage);

        string letter;

        if (value >= 90 )
        {
            letter = "A";
        }
        else if (value >= 80 )
        {
            letter = "B";
        }
        else if (value >= 70 )
        {
            letter = "C";
        }
        else if (value >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        string lastDigit;

        if (value > 10)
        {
            lastDigit = percentage[1].ToString();
        }
        else
        {
            lastDigit = percentage[0].ToString();
        }



        int valueOfLastDigit = int.Parse(lastDigit);

        if (valueOfLastDigit >= 3 && value >= 90)
        {
            Console.WriteLine(letter);
        }
        else if (valueOfLastDigit < 3 && value >= 90)
        {
            Console.WriteLine($"{letter}-");
        }
        else if (valueOfLastDigit >= 7 && value < 90 && value >= 60)
        {
            Console.WriteLine($"{letter}+");
        }
        else if (valueOfLastDigit < 7 && valueOfLastDigit >= 3 && value < 90 && value >= 60)
        {
            Console.WriteLine(letter);
        } 
        else if (valueOfLastDigit < 3 && value < 90 && value >= 60)
        {
            Console.WriteLine($"{letter}-");
        }
        else
        {
            Console.WriteLine(letter);
        } 

        if (value >= 70 )
        {
            Console.WriteLine("Congratulations, You passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed the course. Try harder next semester. You can make it!");
        }
    }
}