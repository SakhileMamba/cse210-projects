public class ListingActivity : Activity
{
    protected int _count;
    protected List<String> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(seconds: 6);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        GetRandomPrompt();

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(10);
        Console.WriteLine();

        List<string> allResponses = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {allResponses.Count} items!");
        Console.WriteLine();

        Console.WriteLine("Well done!!!");
        ShowSpinner(5);
        Console.WriteLine();
        DisplayEndingMessage(); 
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(0, _prompts.Count)];
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }
        return responses;
    }
}