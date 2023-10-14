public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    public string GetGoalName() //Added this method to get each goal's name
    {
        return _shortName;
    }
    public abstract string RecordEvent(); //changed return from void to string

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
} 