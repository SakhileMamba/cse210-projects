using System;
using System.Runtime.Intrinsics.X86;

//I have added a Question class to hold more data about the questions in the reflection activity, i.e whether each questions has been shown or not. The class also has behaviour responsible for modifying its state.

//I have added functionality to update the duration of time taken to complete a reflection activity session in the case a user runs out of questions before the time he had allocated for the session. Please refer to ReflectionActivity.cs file.


class Program
{
    static void Main(string[] args)
    {
        bool keepGoing = true;

        while(keepGoing)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    keepGoing = false;
                    break;
                default:
                    break;                   
            }
        }
    }

}