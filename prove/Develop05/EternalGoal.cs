public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name: name, description: description, points: points)
    {
    
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}