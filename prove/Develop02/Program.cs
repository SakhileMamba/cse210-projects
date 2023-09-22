using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool loop = true;
        string selection = "";

        while (loop == true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What is your selection?: ");
            selection = Console.ReadLine();
            Console.WriteLine();

            switch (selection)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Entry entry = new Entry();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = entryText;
                    journal.AddEntry(entry);
                    Console.WriteLine();
                    break;
                case "2":

                    //Below I have added a conditional statement to check if the are entries in the journal.
                    //If the are entries in the journal, then the program displays them.
                    //If the aren't, then the user is informed and a suggestion is made to write a new journal entry. 

                    if (journal._entries.Count < 1) 
                    {
                        Console.WriteLine("There are no entries in the journal yet. Try loading them from a file or writing a new entry!");
                        Console.WriteLine();
                    }
                    else
                    { 
                        journal.DisplayAll();
                    }

                    break;
                case "3":
                    Console.Write("What is the text filename? ");
                    
                    string loadFilename = Console.ReadLine();

                    //Below I have added a conditional statement to check if a file exists before attempting to load entries from the file.
                    //If the file exists then entries saved on the file are loaded into the journal and are displayed.
                    //If the file does not exist then the user is notified instead of the program throwing an error.

                    if (File.Exists(loadFilename))
                    {
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine("File has been successfully loaded and includes the following entries:");
                        Console.WriteLine();
                        journal.DisplayAll();
                    }
                    else
                    {
                        Console.WriteLine("That file does not exist. Try a different filename!");
                        Console.WriteLine();
                    }
                    
                    break;
                case "4":

                    //Below I have added a conditional statement to check if the journal entries aren't empty before attempting to save them into a file.
                    //If the journal entries are empty, then the user is notified and nothing is saved onto the file. A suggestion is made to the user to write a new entry.
                    //If the journal entries are not empty, these entries are saved to the file.
                    if (journal._entries.Count < 1)
                    {
                        Console.WriteLine("There are no journal entries to save yet. Try writing a new entry!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("What is the text filename? ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine();
                    }
                    
                    break;
                case "5":
                    loop = false;
                    break;

                default:
                    //If a user makes an incorrect selection, he is notified and prompted to make a new selection.
                    Console.WriteLine("Incorrect selection!");
                    Console.WriteLine();
                    break;
            }

        }
    }
}