//Create the Job class
public class Job
{
    //Create member variables in the class for each element that this 
    //class should contain.
   public string _companyName;
   public string _jobTitle;
   public double _startYear;
   public double _endYear;

    //In your Job.cs file and add a method (member function) to display the job
    //details. This method should not have any parameters and does not need to 
    //return anything.
   public void DisplayJobDetails()
   {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
   }
}