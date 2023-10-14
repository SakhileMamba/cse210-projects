/*
In GoalManager.cs, when the user lists his goals, I have added the ability for goals to appear on their own on the screen so the user can focus on them until he presses any key to return to the main menu.

I have also added the ability to notify the user that he has no goals in case he is trying to list or save goals or record an event if he hasn't loaded or created any goals into the list of goals.

I have changed the program so the user doesn't have to input filenames when saving or loading goals. This makes the program easy to use. All goals are saved and loaded from one default file, goals.txt.

If the user is trying to load goals from files yet hasn't saved any prior. He is notified, and the action isn't executed.

In the Goal class. I added a new method that returns the goal's short name. I also changed the record event's method type from void to string.

In the Simple Goal class, I added a new constructor that is used when loading goals from a file. This is because these goals include an extra parameter that determines if the goals have been completed or not. I did the same for the Checklist Goal class because it includes an "amount completed" parameter in the constructor when creating objects loaded from a file.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}