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
            Console.WriteLine("6. Clear");
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

                    //Below I have added a conditional statement to check if there are entries in the journal.
                    //If there are entries in the journal, then the program displays them.
                    //If there aren't, the user is informed, and a suggestion is made to write a new journal entry. 

                    if (journal._entries.Count < 1)
                    {
                        Console.WriteLine("There are no entries in the journal. Try loading them from a file or writing a new entry!");
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

                    //Below I have added a conditional statement to check if a file exists before attempting to load entries from the file into the journal.
                    //If the file exists, then entries saved on the file are loaded into the journal and displayed.
                    //If the file does not exist, then the user is notified instead of the program throwing an error.

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

                    //Below I have added a conditional statement to check if the journal entries list isn't empty before attempting to save the entries into a file.
                    //If the list is empty, the user is notified and nothing is written into the file. A suggestion is made to the user to write a new entry.
                    //If the list is not empty, the entries are saved to the file.
                    if (journal._entries.Count < 1)
                    {
                        Console.WriteLine("There are no journal entries to save to a file. Try writing a new entry!");
                        Console.WriteLine();
                    }
                    else
                    {   
                        //Below I have added the ability to check if a file already exists in the current directory then and give the user an option to overwrite the file if it does exist or save the current list of entries in the journal to a different file.
                        bool loopSave = true;
                        while (loopSave)
                        {
                            Console.Write("What is the text filename? ");
                            string saveFilename = Console.ReadLine();

                            if (File.Exists(saveFilename))
                            {
                                Console.Write("This file already exists. If you continue it will be overwritten. Enter 'y' to overwrite the file or any other letter to choose a different file. ");
                                string overwrite = Console.ReadLine();

                                switch (overwrite)
                                {
                                    case "y":
                                        journal.SaveToFile(saveFilename);
                                        loopSave = false;
                                        Console.WriteLine();
                                        break;

                                }
                            }
                            else
                            {
                                journal.SaveToFile(saveFilename);
                                loopSave = false;
                                Console.WriteLine();
                            }

                        }

                    }
                    break;

                case "5":
                    loop = false;
                    break;
                
                case "6":
                    //Created a new menu option to add the functionality to clear entries in the journal, without restarting the program to give the user more control.
                    if(journal._entries.Count == 0)
                    {
                        Console.WriteLine("There are no current entries to clear in the journal.");
                        Console.WriteLine();
                    }
                    else
                    {
                        journal._entries.Clear();
                        Console.WriteLine("Journal entries have been cleared. Write a new entry or load entries from a file.");
                        Console.WriteLine();
                    }
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