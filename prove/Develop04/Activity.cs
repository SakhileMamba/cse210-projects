public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(int duration)
    {
        _duration = duration;
    }
    
    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerItems = new List<string> {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerItems[i]);
            Thread.Sleep(190);
            Console.Write("\b \b");
            
            i++;

            if (i == spinnerItems.Count)
            {
                i = 0;
            }
        }
        

    }

    public void ShowCountDown(int seconds)
    {
        for( int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if(i > 999)
            {
                Console.Write("\b\b\b\b    \b\b\b\b");
            }
            if(i > 99)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else if(i > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }         
        }
    }
}