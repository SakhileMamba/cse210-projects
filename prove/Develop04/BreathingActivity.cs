public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {   Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(seconds: 6);

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in ... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breath out ... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!!");
        ShowSpinner(5);
        Console.WriteLine();
        DisplayEndingMessage(); 
        ShowSpinner(5);
    }
}