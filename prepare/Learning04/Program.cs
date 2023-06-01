using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Joshua Olaoye", "Fractions", "Section 7.9", "Problem 8-20");
        string studentName = assignment.GetStudentName();
        string topic = assignment.GetTopic();
        string bookSection = assignment.GetTextbookSection();
        string problems = assignment.GetProblems();
        assignment.GetHomeworkList();

        WritingAssignment assignment1 = new WritingAssignment("Joshua Olaoye", "European History", "The Fall of Adam");
        string studentName1 = assignment1.GetStudentName();
        string topic1 = assignment1.GetTopic();
        string title = assignment1.GetTitle();
        assignment1.GetWritingInformation();
    }
}