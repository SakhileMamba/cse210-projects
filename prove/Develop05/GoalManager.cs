public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool loopApp = true;

        while (loopApp)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Main Menu Options:");
            Console.WriteLine();
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case ("1"):
                    CreateGoal();
                    break;
                case ("2"):
                    ListGoalDetails();
                    break;
                case ("3"):
                    SaveGoals();
                    break;
                case ("4"):
                    LoadGoals();
                    break;
                case ("5"):
                    RecordEvent();
                    break;
                case ("6"):
                    loopApp = false;
                    break;
                default:
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your current goals are:");
        Console.WriteLine();

        int numbering = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numbering}.  {goal.GetGoalName()}");
            numbering++;
        }

    }

    public void ListGoalDetails()
    {
        Console.Clear();
        if (_goals.Count > 0)
        {
            Console.WriteLine("Your current goals are:");
            Console.WriteLine();

            int numbering = 1;

            foreach (Goal goal in _goals)
            {

                Console.WriteLine($"{numbering}. {(goal.IsComplete() ? "[x]" : "[ ]")} {goal.GetDetailsString()}");
                numbering++;
            }
        }
        else
        {

            Console.WriteLine("You currently do not have any goals.");

        }
        Console.WriteLine();
        //added the ability for goals to appear on their own until the user presses any key to return to main menu
        Console.Write("Press any key to return to main menu! ");
        Console.ReadLine();
    }

    public void CreateGoal() //#TODO break down repeated code into scope functions
    {
        bool loopCreateGoal = true;

        while (loopCreateGoal)
        //added a loop in the goal creation type selection menu to avoid going back to the root menu without the users explicit consent, this way the user can create multiple goals at once
        {
            Console.Clear();

            Console.WriteLine("Goal Creation Menu Options:");
            Console.WriteLine();
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.WriteLine("  4. Main Menu"); //added an option to cancel creating a goal
            Console.WriteLine();
            Console.Write("Choose a goal to create or go back to main menu? ");
            string goalCreationChoice = Console.ReadLine();

            switch (goalCreationChoice)
            {
                case "1":
                    {
                        Console.Clear();

                        Console.WriteLine("Simple Goal Creation:");
                        Console.WriteLine();

                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is a short description of this goal? ");
                        string goalDescription = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        string goalPoints = Console.ReadLine();

                        SimpleGoal simpleGoal = new SimpleGoal(name: goalName, description: goalDescription, points: goalPoints);

                        _goals.Add(simpleGoal);

                        bool finalStep = true;
                        while (finalStep)
                        {
                            Console.Clear();
                            Console.WriteLine("Your simple goal has been created successfully!");
                            Console.WriteLine();
                            Console.WriteLine("Next Steps:");
                            Console.WriteLine();

                            Console.WriteLine("  1. Create Another Goal");
                            Console.WriteLine("  2. Main Menu");
                            Console.WriteLine();

                            Console.Write("Choose option: ");
                            string afterGoalCreation = Console.ReadLine();

                            switch (afterGoalCreation)
                            {
                                case "1":
                                    finalStep = false;
                                    break;
                                case "2":
                                    finalStep = false;
                                    loopCreateGoal = false;
                                    break;
                                default:
                                    break;
                            }


                        }
                        break;
                    }

                case "2":
                    {
                        Console.Clear();

                        Console.WriteLine("Eternal Goal Creation:");
                        Console.WriteLine();

                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is a short description of this goal? ");
                        string goalDescription = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        string goalPoints = Console.ReadLine();

                        EternalGoal eternalGoal = new EternalGoal(name: goalName, description: goalDescription, points: goalPoints);

                        _goals.Add(eternalGoal);
                        bool finalStep = true;
                        while (finalStep)
                        {
                            Console.Clear();
                            Console.WriteLine("Your Eternal goal has been created successfully!");
                            Console.WriteLine();
                            Console.WriteLine("Next Steps:");
                            Console.WriteLine();

                            Console.WriteLine("  1. Create Another Goal");
                            Console.WriteLine("  2. Main Menu");
                            Console.WriteLine();

                            Console.Write("Choose option: ");
                            string afterGoalCreation = Console.ReadLine();

                            switch (afterGoalCreation)
                            {
                                case "1":
                                    finalStep = false;
                                    break;
                                case "2":
                                    finalStep = false;
                                    loopCreateGoal = false;
                                    break;
                                default:
                                    break;
                            }


                        }
                        break;
                    }

                case "3":
                    {
                        Console.Clear();

                        Console.WriteLine("Checklist Goal Creation:");
                        Console.WriteLine();

                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is a short description of this goal? ");
                        string goalDescription = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        string goalPoints = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("How many times would you like to accomplish this goal? ");
                        int goalTarget = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write($"What will be your bonus for completing this goal {goalTarget} time(s)? "); //I use the goal target to prompt user accurately
                        int goalBonus = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        ChecklistGoal checklistGoal = new ChecklistGoal(name: goalName, description: goalDescription, points: goalPoints, target: goalTarget, bonus: goalBonus);

                        _goals.Add(checklistGoal);

                        bool finalStep = true;
                        while (finalStep)
                        {
                            Console.Clear();
                            Console.WriteLine("Your Checklist goal has been created successfully!");
                            Console.WriteLine();
                            Console.WriteLine("Next Steps:");
                            Console.WriteLine();

                            Console.WriteLine("  1. Create Another Goal");
                            Console.WriteLine("  2. Main Menu");
                            Console.WriteLine();

                            Console.Write("Choose option: ");
                            string afterGoalCreation = Console.ReadLine();

                            switch (afterGoalCreation)
                            {
                                case "1":
                                    finalStep = false;
                                    break;
                                case "2":
                                    finalStep = false;
                                    loopCreateGoal = false;
                                    break;
                                default:
                                    break;
                            }


                        }
                        break;
                    }
                case "4":
                    loopCreateGoal = false;
                    break;
                default:
                    break;

            }
        }
    }

    public void RecordEvent()
    {

        if (_goals.Count > 0)
        {
            bool loopRecordEvent = true;

            while (loopRecordEvent)
            {
                Console.Clear();
                ListGoalNames();
                Console.WriteLine();

                Console.Write("Which goal did you accomplish? ");
                string accomplishedGoal = Console.ReadLine();
                try
                {
                    int index = int.Parse(accomplishedGoal) - 1;
                    if (index < _goals.Count)
                    {
                        string pointsEarned = _goals[index].RecordEvent();
                        _score += int.Parse(pointsEarned);

                        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                        Console.WriteLine();

                        Console.Write("Press any key to return to main menu! ");
                        Console.ReadLine();
                        loopRecordEvent = false;
                    }

                }
                catch
                {

                }
            }
        }
        else
        {
            Console.Clear();
            //User is notified if he has no goals to record event for.
            Console.WriteLine("You currently do not have any goals.");
            Console.WriteLine();

            Console.Write("Press any key to return to main menu! ");
            Console.ReadLine();

        }

    }

    public void SaveGoals()
    {
        if (_goals.Count > 0)
        {
            string filename = "goals.txt";//user does not have to manually input filename
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                int index = 0;
                streamWriter.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    streamWriter.WriteLine(_goals[index].GetStringRepresentation());
                    index++;
                }
            }
            Console.Clear(); 
            Console.WriteLine($"Your goals have been successfully saved to file!");
            Console.WriteLine();

            Console.Write("Press any key to return to main menu! ");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            //User is notified if he has no goals to save to file.
            Console.WriteLine("You currently do not have any goals to save to a file.");
            Console.WriteLine();

            Console.Write("Press any key to return to main menu! ");
            Console.ReadLine();
        }

    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt")) // check if any save files exist
        {
            
            string filename = "goals.txt";
            string[] saved = File.ReadAllLines(filename);

            _score = int.Parse(saved.First());

            for (int i = 1; i < saved.Count(); i++)
            {
                string[] typeAndInfo = saved[i].Split(":");
                if (typeAndInfo[0] == "SimpleGoal")
                {
                    string[] info = typeAndInfo[1].Split(",");
                    SimpleGoal simpleGoal = new SimpleGoal(name: info[0], description: info[1], points: info[2], isComplete: info[3] == "True" ? true : false);
                    _goals.Add(simpleGoal);
                }
                else if (typeAndInfo[0] == "EternalGoal")
                {
                    string[] info = typeAndInfo[1].Split(",");
                    EternalGoal eternalGoal = new EternalGoal(name: info[0], description: info[1], points: info[2]);
                    _goals.Add(eternalGoal);
                }
                else if (typeAndInfo[0] == "ChecklistGoal")
                {
                    string[] info = typeAndInfo[1].Split(",");
                    ChecklistGoal checklistGoal = new ChecklistGoal(name: info[0], description: info[1], points: info[2], amountCompleted: int.Parse(info[3]), target: int.Parse(info[4]), bonus: int.Parse(info[5]));
                    _goals.Add(checklistGoal);
                }

            }
            Console.Clear();
            
            Console.WriteLine($"Your goals have been successfully loaded from file!");
            Console.WriteLine();

            Console.Write("Press any key to return to main menu! ");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            //User is notified if he has no saved file.
            Console.WriteLine("You currently do not have any goals saved to file.");
            Console.WriteLine();

            Console.Write("Press any key to return to main menu! ");
            Console.ReadLine();
        }

    }


}