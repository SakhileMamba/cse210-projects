using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference;
        Scripture scripture;

        //I have added the ability for the user to input the scripture he wants to memorize.
        Console.WriteLine("Enter the scripture you want to memorize");
        Console.WriteLine();

        Console.Write("Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Start verse: ");
        string verse = Console.ReadLine();
        Console.Write("End verse if different from start verse, otherwise press enter: ");
        string endVerse = Console.ReadLine();
        Console.Write("Scripture's text: ");
        string scriptureText = Console.ReadLine();
        Console.Clear();


        if (endVerse == "")
        {
            reference = new Reference(book: book, chapter: int.Parse(chapter), verse: int.Parse(verse));
        }
        else
        {
            reference = new Reference(book: book, chapter: int.Parse(chapter), startVerse: int.Parse(verse), endVerse: int.Parse(endVerse));
        }

        scripture = new Scripture(reference: reference, text: scriptureText);


        /*
            The following loop gives the program the ability for the user to memorize the same scripture again without having
            to restart the program and re-enter the scripture.
        */
        bool keepMemorizing = true;
        while (keepMemorizing)
        {
            bool quit = false;
            bool loop = true;
            Random random = new Random();

            while (loop && quit != true)
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                string reply = Console.ReadLine();
                if (reply == "quit")
                {
                    quit = true;
                    keepMemorizing = false;
                }

                if (!scripture.IsCompletelyHidden())
                {
                    scripture.HideRandomWords(random.Next(1, scripture.AvailableWords()));
                    Console.Clear();
                }
                else
                {
                    loop = false;
                }
            }

            /*
            The following loop presents the user with options to choose whether to memorize the scripture again without having
            to restart the program and re-enter the scripture or the option to exit the program.
            */
            if (quit == false)
            {
                bool answered = false;
                while (!answered)
                {
                    Console.Write("Do you want to memorize this scripture again? y/n?: ");
                    string reply = Console.ReadLine();
                    switch (reply)
                    {
                        case ("y"):
                            answered = true;
                            scripture.ShowAll();
                            Console.Clear();
                            break;
                        case ("n"):
                            answered = true;
                            keepMemorizing = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}