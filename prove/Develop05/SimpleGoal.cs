public class Simple : Goals
{
    public override void GoalQuestions(string goalType)
    {
        base.GoalQuestions(goalType);
    }

    public override void UpdateTotalGoalPoint(int points)
    {
        if (GetTotalGoalPoint() == 0)
        {
            base.UpdateTotalGoalPoint(points);
        }
    }
}