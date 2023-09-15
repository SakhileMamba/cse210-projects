using System;

class Program
{
    static void Main(string[] args)
    {
        string playAnotherGame = "yes";

        do {

        bool keepPlaying = true;

        Random randomNumberGenerator = new Random();
         int magicNumber = randomNumberGenerator.Next(1, 100);

        int numberOfGuesses = 0;

        while (keepPlaying)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            numberOfGuesses++;

            if (guess < magicNumber)
            {   
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                keepPlaying = false;
            }

            Console.WriteLine("");
        }

        Console.WriteLine($"You made {numberOfGuesses} guesses.");

        Console.Write("Would you like to play again? yes/no: ");
        playAnotherGame = Console.ReadLine();
        Console.WriteLine("");

        } while (playAnotherGame == "yes");
    }
}