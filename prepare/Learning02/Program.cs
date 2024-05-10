using System;
using System.Collections.Generic;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//     }
// }

// Okay, so I need to define two classes. The first one will hold the information for a single job and
// the second one will be a resume that will keep track of the different jobs and the individual's name.
// As per the instructions, those are defined inside another file.
class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        Resume MyResume = new Resume();
        
        
        Console.Write("What is your name? ");
        MyResume._name = Console.ReadLine();        
        
        string response;
        int iterations = 1;
        do
        {
            Console.WriteLine($"\nJob {iterations}\n");
            Console.Write("What is the company name? ");
            job._companyName = Console.ReadLine();

            Console.Write("What is the job title? ");
            job._jobTitle = Console.ReadLine();

            Console.Write("What is the year that you started this job? ");
            job._startYear = int.Parse(Console.ReadLine());

            Console.Write("What year did you terminate this job? ");
            job._endYear = int.Parse(Console.ReadLine());

            string DisplayThis = $"{job._jobTitle} ({job._companyName}); {job._startYear}-{job._endYear}";
            MyResume._jobs.Add(DisplayThis);

            Console.Write("\nDo you have another job to enter? ");
            response = Console.ReadLine();

            iterations += 1;

        } while (response.ToLower() == "yes");
        Console.WriteLine();
        // MyResume.DisplayResume(MyResume._name,MyResume._jobs);
        MyResume.Display();
        Console.WriteLine();
    }
}