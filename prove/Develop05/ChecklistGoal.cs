public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name: name, description: description, points: points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

     public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name: name, description: description, points: points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }//constructor for checklist goals loaded from a  file.

    public override string RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            int earned = int.Parse(_points) + _bonus;
            return earned.ToString();
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}