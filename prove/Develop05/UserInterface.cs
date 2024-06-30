using System.Collections.Generic;
using System.Security.Cryptography;
public class UserInteractions{
    // Attributes:
    

    // Constructors:
    public UserInteractions(){
    }

    // Methods:
    public void DisplayMenu(string Menu){
        Console.Write(Menu);
    }
    public void DisplayIntro(string Intro){
        Console.WriteLine(Intro);
    }
    public void DisplayInstructions(string Instructions){
        Console.WriteLine(Instructions);
    }
    public void DisplayOutro(string Outro){
        Console.WriteLine(Outro);
    }
    public List<Goal> StockGoalItem(){
    /*Okay. This method will take the contents of a text file and turn it into */
        string FileName = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(FileName);

        List<Goal> Goals = new List<Goal>();
        List<string> GoalStrings = new List<string>();
        foreach(string line in lines){
            GoalStrings.Add(line.Trim());
            // string[] parts = line.Split(":");
        }
        foreach (string i in GoalStrings){
            List<string> TestList = new List<string>(i.Split(","));
            string TestVariable = TestList[1];
            List<string> TestList2 = new List<string>();
            foreach (string _part in TestVariable.Split(",")){
                TestList2.Add(_part);
            }
            if (TestList[0].ToLower() == "goal"){
                Goal AGoal = new Goal(TestList2[0],DateTime.Parse(TestList2[1]),int.Parse(TestList2[3]),bool.Parse(TestList2[4]));
                Goals.Add(AGoal);
            }
            // else if (TestList[0].ToLower() == "simplegoal"){}
            else if (TestList[0].ToLower() == "listgoal"){
                ListGoal AGoal = new ListGoal(TestList2[0],DateTime.Parse(TestList2[1]),int.Parse(TestList2[3]),bool.Parse(TestList2[4]),int.Parse(TestList2[5]),int.Parse(TestList2[6]),int.Parse(TestList2[7]));
            }
            else if (TestList[0].ToLower() == "longtermgoal"){
                LongtermGoal Agoal = new LongtermGoal();
            }
        }
        

    return Goals;
    }

    public void GoalsToRecord(string goal){

    }
}