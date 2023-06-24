public class Goals
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoint;
    private int _totalGoalPoint;

    public Goals()
    {
    }

    // GoalType
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    // GoalName
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    // GoalDescription
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    // GoalPoints
    public void SetPoints(int goalPoint)
    {
        _goalPoint = goalPoint;
    }
    public int GetGoalPoint()
    {
        return _goalPoint;
    }

    public virtual void UpdateTotalGoalPoint(int points)
    {
        _totalGoalPoint += points;
    }

    public int GetTotalGoalPoint()
    {
        return _totalGoalPoint;
    }

    public virtual void GoalQuestions(string goalType)
    {
        _goalType = goalType;
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        string gp = Console.ReadLine();
        _goalPoint = int.Parse(gp);
        Console.WriteLine();
    }

    public void DisplayGoalDetails(int goalNumber, bool isCompleted)
    {
        // Process goalNumber = new Process();
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{goalNumber}. {status} {_goalName} ({_goalDescription})");
    }

}