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
        return $"{_date} {_name} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }


}