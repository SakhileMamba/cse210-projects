public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name: name, description: description, points: points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name: name, description: description, points: points)
    {
        _isComplete = isComplete;
    }//constructor for when loading goals from file.

    public override string RecordEvent()
    {
        _isComplete = true;
        return _points;
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}