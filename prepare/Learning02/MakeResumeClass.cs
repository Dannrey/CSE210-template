public class Resume
{

    // As I'm sure you can see, there are two variables included in it, the one to hold your name, and the list
    // to hold your different jobs.
    public string _name;
    public List<string> _jobs = new List<string>();
    
    // Again, I don't know what this does, but it seems pretty important since in all of my test classes none 
    // of them worked without this being prooerly defined.
    public Resume()
    {
    }

    // Lastly, here is the function that I made to sort through the list of jobs and display all the information
    // to the computer screen.
    public void DisplayResume(string name, List<string> jobs)
    {
        Console.WriteLine($"Name: {name}\nJobs:");
        foreach (string job in jobs)
        {
            Console.WriteLine($"{job}");
        }
    }
    // Okay, so this last function that I made is not what I was asked to do, so instead you get two separate
    // functions that do the exact same thing.
    // So, instead, I used this which actually works just as well:
    public void Display()
    {
        Console.WriteLine($"\nName: {_name}\n");
        Console.WriteLine("Jobs:");
        foreach (string job in _jobs)
        {
            Console.WriteLine($"{job}");
        }
    }
}