using System;
using System.IO;

class Program
{
    static void Main(string[] args){
        LifetimeStatistics Stats = new LifetimeStatistics();
        string menu = "Options\n\t1. Create a new goal.\n\t.2 Create a new longterm goal.\n\t3. Create a new list goal.\n\t4. View Lifetime Statistics.\n\t5. Mark current goal complete.\n\t6. End/terminate current running goal.\n\t7. Quit application\nPlease type a numeric option indicated by your desired activity:";
        Console.WriteLine("Hello! I am your Goal Listing Application Device, but you may call me G.L.A.D.\nMy purpose today is to assist you in making and keeping track of goals.");
        Console.WriteLine("Below are the options that you can choose from:");
        Console.Write(menu);
        string Activity = Console.ReadLine();
        do{
            if (Activity == "1"){
                Goal NewGoal = new Goal();
                
            }
        } while(Activity != "7");
        Console.WriteLine("Have a nice day!");
    }
}