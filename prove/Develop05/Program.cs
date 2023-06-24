using System;

class Program
{
    static void Main(string[] args)
    {
        Goals totalGoals = new Goals();
        Process goals = new Process();
        bool quitGame = false;
        while (!quitGame)
        {
            Console.WriteLine($"You have {totalGoals.GetTotalGoalPoint()} points.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("7. Delete a Goal");

            string menuResponse = Console.ReadLine();
            int menuReply = int.Parse(menuResponse);
            Console.WriteLine();


            if (menuReply == 1)
            {
                Console.WriteLine("Select a choice from the menu: ");
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string goalResponse = Console.ReadLine();
                int goalReply = int.Parse(goalResponse);
                Console.WriteLine();

                if (goalReply == 1)
                {
                    Simple simpleGoal = new Simple();
                    simpleGoal.GoalQuestions("Simple");
                    goals._goalsList.Add(simpleGoal);
                }
                else if (goalReply == 2)
                {
                    Eternal eternalGoal = new Eternal();
                    eternalGoal.GoalQuestions("Eternal");
                    goals._goalsList.Add(eternalGoal);
                }
                else if (goalReply == 3)
                {
                    Checklist checklistGoal = new Checklist();
                    checklistGoal.GoalQuestions("Checklist");
                    goals._goalsList.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("You pressed the wrong option. Reload and try again.");
                }
            }
            else if (menuReply == 2)
            {
                goals.DisplayGoals();
                Console.WriteLine();
            }
            else if (menuReply == 3)
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string docName = Console.ReadLine();
                // goals.SetFilename(docName);
                goals.SaveProgress(docName);
            }
            else if (menuReply == 4)
            {
                Console.WriteLine("What is the filename of the goal file? ");
                string docName = Console.ReadLine();
                goals.LoadProgress(docName);
            }
            else if (menuReply == 5)
            {
                goals.RecordEvent(totalGoals);
            }
            else if (menuReply == 6)
            {
                Console.WriteLine("You racked up good points today! Don't hesitate to come back for more points!");
                quitGame = true;
            }
            else if (menuReply == 7)
            {
                Console.WriteLine("What goal do you want to delete?");
                int index = int.Parse(Console.ReadLine());
                index -= 1;
                goals.DeleteGoal(goals._goalsList[index]);
                Console.WriteLine("Entry deleted successfully");
            }
            else
            {
                Console.WriteLine("You pressed the wrong option. Reload and try again.");
            }
        }
    }
}

