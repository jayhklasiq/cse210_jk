using System;

class Program
{
    //In your Program.cs file, add code to your Main function. 
    static void Main(string[] args)
    {
        //Create a new job instance named job1
        Job job1 = new Job();
        //Set the member variables using the dot notation
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;
        //In your Program.cs file. Remove the lines of code where you displayed the
        //company earlier, and replace them with calls to your new method. Remember that you
        //call the method using the same dot notation such as job1.Display();
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Customer Care Representative";
        job2._companyName = "Amazon";
        job2._startYear = 2012;
        job2._endYear = 2019;
        // job1.DisplayJobDetails();

        //At the end of the Main function, create a new instance
        //of the Resume class.
        Resume resume1 = new Resume();
        //Add the two jobs you created earlier, to the list of jobs in the resume object.
        resume1._fullName = "Joshua Olaoye";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        //Verify that you can access and display the first job title using dot notation similar to
        //myResume._jobs[0]._jobTitle
        // Console.WriteLine(resume1._jobList[0]._jobTitle);

        //In your main function, remove any code that is displaying information, and
        //instead, add a call at the end to the Display method from your Resume class to display
        //the name and all the jobs in one line.
        resume1.DisplayResume(); 
    }
}


