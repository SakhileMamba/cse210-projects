public abstract class Activity
{
    private string _date;
    protected int _length; //in minutes
    protected string _name;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min): Distance {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km";
    }


}