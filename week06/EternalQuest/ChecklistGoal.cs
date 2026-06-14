public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int bonus,
        int targetCount,
        int currentCount = 0)
        : base(name, description, points)
    {
        _bonus = bonus;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;

            if (_currentCount == _targetCount)
            {
                return GetPoints() + _bonus;
            }

            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
