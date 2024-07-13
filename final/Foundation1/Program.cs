using System;

class Program
{
    static void Main(string[] args){
        Console.Clear();
        // These are the instructory lines of the program.
        Console.WriteLine("Hello and greetings! I am the Video Listing and Analytics Device, but you may call me V.L.A.D.");
        // Thread.Sleep(4000);
        Console.WriteLine("My purpose today is to assist you help organize analytic data from YouTube videos.");
        // Thread.Sleep(4000);
        Console.WriteLine("I shall list through a number of videos and display to you their contents.\nFollow the onscreen instructions as they appear.");
        // Thread.Sleep(4000);
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();

        // 
        Random random = new Random();
        int VideoCount = random.Next(2,5);
        int iteration = 0;
        List<YouTubeVideo> Videos = new List<YouTubeVideo>();
        while (iteration != VideoCount){
            YouTubeVideo Video = new YouTubeVideo();
            Videos.Add(Video);
            // Video.GetVideoStats();
            iteration += 1;
        }
        Console.Write("Hit enter when you are ready to begin analyzing the videos: ");
        Console.ReadLine();
        foreach (YouTubeVideo video in Videos){
            Console.Clear();
            video.GetVideoStats();
            video.DisplayComments();
        }
        
    }
}