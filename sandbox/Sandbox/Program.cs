using System;
using System.IO;
using System.Collections.Generic;


// Okay. So, today I am testing out how to create a dictionary. In hindsight, I probably should have done this sooner, but hey, hindsight is 20: 20.
class Program{
    static void Main(string[] args){
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(10);
        DateTime CurrentTime = DateTime.Now;
        int x = 0;
        do{
            if (x < 3){
                if (x == 0){
                    Console.Clear();
                    Console.WriteLine("Breathe in");
                }
                x += 1;
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                Console.Write("--");
                Thread.Sleep(125);
                // Console.Write(x);   // This is test code. Comment
            }
            else if (x == 3){
                x += 1;
                Console.Clear();
                Console.WriteLine("Hold it");
                Console.Write("================================================");
                Thread.Sleep(1000);
            }
            else if (x == 6){
                x += 1;
                Console.Clear();
                Console.WriteLine("Exhale");
                Console.Write("------------------------------------------------");
                // Thread.Sleep(125);
                Console.Write("\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
            }
            else if (x == 10) {
                x = 0;
                Console.Clear();
            }
            else if (x > 6){
                x += 1;
                Console.Write("\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
                Console.Write("\b\b \b\b ");
                Thread.Sleep(125);
            }
            else{
                x += 1;
            }
            CurrentTime = DateTime.Now;
        } while (CurrentTime != EndTime && CurrentTime < EndTime);
    }
}