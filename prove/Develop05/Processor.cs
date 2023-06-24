using System;
public class Process
{
    public List<Goals> _goalsList = new List<Goals>();
    private bool _status = false;
    public void AddGoal(Goals goal)
    {
        _goalsList.Add(goal);
    }
    private string _filename;
    public void SetFilename(string docName)
    {
        _filename = docName;
    }

    Checklist checklistGoal = new Checklist();



    public void SaveProgress(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goals entry in _goalsList)
            {
                if (entry.GetGoalType() == "Eternal")
                {
                    outputFile.WriteLine($"{entry.GetGoalType()}|{entry.GetGoalName()}|{entry.GetGoalDescription()}|{entry.GetGoalPoint()}");
                }
                else if (entry.GetGoalType() == "Simple")
                {
                    outputFile.WriteLine($"{entry.GetGoalType()}|{entry.GetGoalName()}|{entry.GetGoalDescription()}|{entry.GetGoalPoint()}|{_status}");
                }
                else if (entry.GetGoalType() == "Checklist")
                {
                    outputFile.WriteLine($"{entry.GetGoalType()}|{entry.GetGoalName()}|{entry.GetGoalDescription()}|{entry.GetGoalPoint()}|{checklistGoal.GetGoalBonus()}|{checklistGoal.GetCompletedGoalMark()}|{checklistGoal.GetGoalMark()}");
                }
            }
        }
    }

    public void LoadProgress(string filename)
    {
        string[] goalfile = System.IO.File.ReadAllLines(filename);
        foreach (string line in goalfile)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                string goalPoint = parts[3];
                Goals access = new Goals();
                access.SetGoalType(goalType);
                access.SetGoalName(goalName);
                access.SetGoalDescription(goalDescription);
                access.SetPoints(int.Parse(goalPoint));
                _goalsList.Add(access);
            }
            else if (parts.Length == 5)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                string goalPoint = parts[3];
                string BoolCondition = parts[4];
                Goals access = new Goals();
                access.SetGoalType(goalType);
                access.SetGoalName(goalName);
                access.SetGoalDescription(goalDescription);
                access.SetPoints(int.Parse(goalPoint));
                if (BoolCondition == "True")
                {
                    _status = true;
                }
                else
                {
                    _status = false;
                }
                _goalsList.Add(access);
            }
            else if (parts.Length == 7)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                string goalPoint = parts[3];
                string goalBonus = parts[4];
                string completedGoal = parts[5];
                string goalMark = parts[6];
                Goals access = new Goals();
                access.SetGoalType(goalType);
                access.SetGoalName(goalName);
                access.SetGoalDescription(goalDescription);
                access.SetPoints(int.Parse(goalPoint));
                checklistGoal.SetGoalBonus(int.Parse(goalBonus));
                checklistGoal.SetGoalMark(int.Parse(goalMark));
                checklistGoal.SetCompletedGoalMark(int.Parse(completedGoal));
                _goalsList.Add(access);
            }

        }
    }

    public void RecordEvent(Goals totalGoals)
    {
        Console.WriteLine("Which goal did you complete? Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= _goalsList.Count)
        {
            Goals completedGoal = _goalsList[goalNumber - 1];
            int goalPoint = completedGoal.GetGoalPoint();

            if (completedGoal.GetGoalType() == "Checklist")
            {
                Checklist checklistGoal = (Checklist)completedGoal;
                int currentCompletedGoalMark = checklistGoal.GetCompletedGoalMark();
                int goalMark = checklistGoal.GetGoalMark();

                if (currentCompletedGoalMark < goalMark)
                {
                    checklistGoal.SetCompletedGoalMark(currentCompletedGoalMark + 1);

                    if (currentCompletedGoalMark + 1 == goalMark)
                    {
                        Console.WriteLine("Congratulations! You have completed the checklist goal!");
                    }
                }
                else
                {
                    Console.WriteLine("Congratulations! You have completed the goal!");
                    completedGoal.UpdateTotalGoalPoint(goalPoint);
                }
            }
            else if (completedGoal.GetGoalType() == "Eternal")
            {
                Console.WriteLine("Congratulations! You have completed the goal!");
                completedGoal.UpdateTotalGoalPoint(goalPoint);
            }
            else if (completedGoal.GetGoalType() == "Simple")
            {
                Simple simpleGoal = (Simple)completedGoal;
                if (simpleGoal.GetTotalGoalPoint() == 0)
                {
                    Console.WriteLine("Congratulations! You have completed the goal!");
                    completedGoal.UpdateTotalGoalPoint(goalPoint);
                    _status = true;
                }
                else
                {
                    Console.WriteLine("You have already completed this goal.");
                }
            }

            Console.WriteLine($"You have earned {completedGoal.GetGoalPoint()} points.");
            totalGoals.UpdateTotalGoalPoint(completedGoal.GetGoalPoint());
            Console.WriteLine($"You now have: {totalGoals.GetTotalGoalPoint()} points.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }

    }
    public void DisplayGoals()
    {
        Console.WriteLine("Your goals are: ");
        int goalNumber = 1;
        foreach (Goals goal in _goalsList)
        {
            bool isCompleted = false;
            if (goal.GetGoalType() == "Simple" || goal.GetGoalType() == "Checklist")
            {
                if (goal.GetTotalGoalPoint() > 0)
                {
                    isCompleted = true;
                }
                goal.DisplayGoalDetails(goalNumber, isCompleted);
                goalNumber++;
            }
        }
    }

    public void DeleteGoal(Goals goal)
    {
        _goalsList.Remove(goal);
    }
}