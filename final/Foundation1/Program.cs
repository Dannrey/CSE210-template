using System;

class Program
{
    static void Main(string[] args){
        // These are the instructory lines of the program.
        Console.WriteLine("Hello and greetings! I am the Video Listing and Analytics Device, but you may call me V.L.A.D.");
        Thread.Sleep(2000);
        Console.WriteLine("My purpose today is to assist you help organize analytic data from YouTube videos.");
        Thread.Sleep(2000);
        Console.WriteLine("I shall list through a number of videos and display to you their contents. Follow the onscreen instructions as they appear.");
        Thread.Sleep(2000);
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();

        // 
        
        YouTubeVideo Video = new YouTubeVideo();
    }
}