using System;

class Program{
    static void Main(string[] args){
        Console.Clear();
        // Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("I shall list a number of sessions, one for track running, one for swimming laps, and one for mounted bicycling.\nPlease follow the onscreen instructions.");
        Console.Write("Hit the enter key when you are ready to begin: ");
        Console.ReadLine();
        Console.Clear();

        List<Activity> Activities = new List<Activity>();
        RunningActivity TrackSession = new RunningActivity();
        // Console.Clear();
        Activities.Add(TrackSession);
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        SwimmingActivity SwimPractice = new SwimmingActivity();
        Activities.Add(SwimPractice);
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        BikingActivity MountedBike = new BikingActivity();
        Activities.Add(MountedBike);
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        foreach (Activity activity in Activities){
            activity.PrintSummaryString();
            // Console.
        }
        Console.Write("\nHit the enter key when you are ready to close the application: ");
        Console.ReadLine();
        Console.Clear();
    }
}