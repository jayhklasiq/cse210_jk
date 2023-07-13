public class Checklist : Goals
{
  private int _goalMark;
  private int _goalBonus;
  private int _completedGoalMark;

  public void SetGoalMark(int goalMark)
  {
    _goalMark = goalMark;
  }

  public int GetGoalMark()
  {
    return _goalMark;
  }

  public void SetGoalBonus(int goalBonus)
  {
    _goalBonus = goalBonus;
  }

  public int GetGoalBonus()
  {
    return _goalBonus;
  }

  public void SetCompletedGoalMark(int completedGoalMark)
  {
    _completedGoalMark = completedGoalMark;
  }

  public int GetCompletedGoalMark()
  {
    return _completedGoalMark;
  }

  public override void GoalQuestions(string goalType)
  {
    base.GoalQuestions(goalType);

    Console.WriteLine("How many times does this goal need to be accomplished before receiving a bonus?");
    _goalMark = int.Parse(Console.ReadLine());

    Console.WriteLine("What is the bonus points for accomplishing it that many times? ");
    _goalBonus = int.Parse(Console.ReadLine());
  }
}