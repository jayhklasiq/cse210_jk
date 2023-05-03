//Create the Resume class
public class Resume
{
    // Create the member variable for the person's name
    public string _fullName;
    //Create the member variable for the list of Jobs. (Hint: the data type for this should be
    //List<Job> , and it is probably easiest to initialize this to a new list right when you
    //declare it..)
    public List<Job> _jobList = new List<Job>();
    //add a method to display its details.
    //This method should not have any parameters and should not return anything
    public void DisplayResume()
    {
        //In the method body, you should display the person's name and then iterate through
        //each Job instance in the list of jobs and display them
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
    }
}