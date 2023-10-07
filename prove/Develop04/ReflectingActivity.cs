public class ReflectingActivity : Activity
{
    protected List<string> _prompts;

    //Made the question a class instead of a string so it has an attribute to determine if it has been shown to the user. If it has been shown, a different question is shown.
    protected List<Question> _questions;

    //added this variable to keep track of whether questions have run out before the session's time
    private bool _ranOutOfQuestionsBeforeTime;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

        _questions = new List<Question> { new Question(text: "Why was this experience meaningful to you?"), new Question(text: "Have you ever done anything like this before?"), new Question(text: "How did you get started?"), new Question(text: "How did you feel when it was complete?"), new Question(text: "What made this time different than other times when you were not as successful?"), new Question(text: "What is your favorite thing about this experience?"), new Question(text: "What could you learn from this experience that applies to other situations?"), new Question(text: "What did you learn about yourself through this experience?"), new Question(text: "How can you keep this experience in mind in the future?") };

        _ranOutOfQuestionsBeforeTime = false;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(seconds: 6);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(10);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime && !_ranOutOfQuestionsBeforeTime)
        {
            DisplayQuestions();
            if (!_ranOutOfQuestionsBeforeTime)
            {
                Console.WriteLine();
            }

        }

        //Updates the duration of time taken to complete the session in the case a user run out of questions before the time he had allocated for this reflection session.
        if (_ranOutOfQuestionsBeforeTime)
        {
            TimeSpan newDuration = DateTime.Now - startTime;
            _duration = newDuration.Seconds - 5; //The 5 seconds subtrated here is to account for the spinners time (5 seconds) in the DisplayQuestions function when the user is notified that he has run out of questions early. This is because the program has to run that function before it updates the new duration that the user has taken for this exercise.
        }

        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        ShowSpinner(5);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(0, _prompts.Count)];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        //Checks to see if the are available questions that haven't been shown in this session yet. If the are the program is able to return a question to the user. Otherwise the reflection session is ended.
        bool atleastOneQuestionNotShown = false;
        foreach (Question question in _questions)
        {
            if (question.IsAvailableToShow())
            {
                atleastOneQuestionNotShown = true;
            }

        }

        if (atleastOneQuestionNotShown)
        {
            Random random = new Random();
            int rounds = 0;
            string text;
            void RecursiveFindQuestionNotShownYet()
            {

                int index = random.Next(0, _questions.Count);
                if (_questions[index].IsAvailableToShow())
                {
                    _questions[index].Show();
                    rounds += 1;
                    text = _questions[index].GetDisplayText();
                }
                else
                {
                    RecursiveFindQuestionNotShownYet();
                }

            }

            RecursiveFindQuestionNotShownYet();
            

            return text;
        }
        else
        {
            return "-1";
        }


    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        if (question == "-1")
        {
            //User is notified in the event a reflection session has to end because he has run out of question.
            Console.WriteLine();
            Console.WriteLine("You have run out of questions early. This session is will be ended.");
            _ranOutOfQuestionsBeforeTime = true;
            ShowSpinner(5);

        }
        else
        {
            Console.Write($"> {question} ");
            ShowSpinner(20);
        }
    }
}