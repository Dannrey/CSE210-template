using System;

class Program
{
    static void Main(string[] args){
        Console.Clear();
        // These are the instructory lines of the program.
        Console.WriteLine("\nHello and greetings! I am the Video Listing and Analytics Device, but you may call me V.L.A.D.");
        Thread.Sleep(2500);
        Console.WriteLine("My purpose today is to assist you help organize analytic data from YouTube videos.");
        Thread.Sleep(2500);
        Console.WriteLine("I shall aid you in cataloguing a number of videos and display to you their contents after we finish.");
        Thread.Sleep(2500);
        Console.WriteLine("Follow the onscreen instructions as they appear.");
        Thread.Sleep(2500);
        Console.Write("\nHit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        // 
        Random random = new Random();
        int VideoCount = random.Next(2,5);  // These need to switc when I am done testing.
        // int VideoCount = random.Next(1,2);  // These need to switc when I am done testing.
        int iteration = 0;
        List<YouTubeVideo> Videos = new List<YouTubeVideo>();

        Console.WriteLine($"Today, we will be working with {VideoCount} videos.");
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();
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