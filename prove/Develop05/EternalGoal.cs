public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name: name, description: description, points: points)
    {
    
    }

    public override string RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}