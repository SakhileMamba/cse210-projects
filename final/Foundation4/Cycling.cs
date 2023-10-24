public class Cycling :Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date: date, length: length)
    {
        _speed = speed;
        _name = "Cycling";
    }

    public override double GetDistance()
    {
        return _length / GetPace();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}