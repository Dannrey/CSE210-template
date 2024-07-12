using System;
using System.IO;

class Program
{
    static void Main(string[] args){
        // List<string> GR = new List<string>();  // GR stands for goal representations

        LifetimeStatistics Stats = new LifetimeStatistics();
        UserInteractions Interface = new UserInteractions();   // Alright. Now I can apply

        string menu = "Options\n\t1. Create a new goal.\n\t.2 Create a new longterm goal.\n\t3. Create a new list goal.\n\t4. View Lifetime Statistics.\n\t5. Mark current goal complete.\n\t6. End/terminate current running goal.\n\t7. Quit application\nPlease type a numeric option indicated by your desired activity:";
        Console.WriteLine("Hello! I am your Goal Listing Application Device, but you may call me G.L.A.D.\nMy purpose today is to assist you in making and keeping track of goals.");
        Console.WriteLine("Below are the options that you can choose from:");
        Console.Write(menu);
        string Activity = Console.ReadLine();
        do{
            if (Activity == "1"){
                Goal NewGoal = new Goal();
                string GoalItem = NewGoal.GetClassRepresentation();
                Interface.AddNewGoal(GoalItem,NewGoal);
            }
            else if (Activity == "2"){
                ListGoal NewGoal = new ListGoal();
                string GoalItem = NewGoal.GetClassRepresentation();
                Interface.AddNewGoal(GoalItem,NewGoal);
            }
            else if (Activity == "3"){
                LongtermGoal NewGoal = new LongtermGoal();
                string GoalItem = NewGoal.GetClassRepresentation();
                Interface.AddNewGoal(GoalItem,NewGoal);
            }
            else if (Activity == "4"){
                Stats.DisplayLifetimeStatistics();
            }
            else if (Activity == "5"){
                // First I will have the program import the string list of goals.
                // Second, I'll split the strings at the commas 
                // That will then call the specific "MarkGoalComplete" method from the corresponding class and add points
                // to the total score and mark the goal, at the least, one point closer to completiion. 

            }

        } while(Activity != "7");
        Console.WriteLine("Have a nice day!");
    }
}