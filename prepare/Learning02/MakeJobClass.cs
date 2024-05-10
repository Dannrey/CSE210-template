public class Job
{
    // I have four variabls inside it, as specified in the activity instructions.
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Now, I'm not sure what this is, but it seems pretty important to get the class to work.
    public Job()
    {
    }

    // And here is the function that I made for this class, which come to think of it, I didn't actually use it
    // in my final version of my program.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}); {_startYear}-{_endYear}");
    }
}