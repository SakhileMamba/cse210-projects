using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(date: "03 Jan 2023", length: 50, 105);
        Cycling cycling = new Cycling(date: "25 May 2023", length: 26, speed: 10);
        Swimming swimming = new Swimming(date: "16 Jul 2023", length: 80, laps: 40);

        List<Activity> list = new List<Activity> { running, cycling, swimming };

        Console.Clear();
        foreach (Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());

        }
    }
}