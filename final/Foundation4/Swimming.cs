public class Swimming :Activity
{
    private int _laps; //50 meters per lap

    public Swimming(string date, int length, int laps) : base(date: date, length: length)
    {
        _laps = laps;
        _name = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}