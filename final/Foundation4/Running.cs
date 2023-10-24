public class Running :Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date: date, length: length)
    {
        _distance = distance;
        _name = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}