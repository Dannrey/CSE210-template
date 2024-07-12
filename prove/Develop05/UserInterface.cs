using System.Collections.Generic;
// using System.Security.Cryptography;
public class UserInteractions{
    // Attributes:
    private List<Goal> _goalList = new List<Goal>();
    private List<string> _stringGoalList = new List<string>();

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
    public void StockGoalItem(){
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
                Goal AGoal = new Goal(TestList2[1],DateTime.Parse(TestList2[2]),int.Parse(TestList2[3]),bool.Parse(TestList2[4]));
                _goalList.Add(AGoal);
            }
            // else if (TestList[0].ToLower() == "simplegoal"){}
            else if (TestList[0].ToLower() == "listgoal"){
                ListGoal AGoal = new ListGoal(TestList2[1],DateTime.Parse(TestList2[2]),int.Parse(TestList2[3]),bool.Parse(TestList2[4]),int.Parse(TestList2[5]),int.Parse(TestList2[6]),int.Parse(TestList2[7]));
                _goalList.Add(AGoal);
            }
            else if (TestList[0].ToLower() == "longtermgoal"){
                LongtermGoal AGoal = new LongtermGoal(TestList2[1],DateTime.Parse(TestList2[2]),int.Parse(TestList2[3]),bool.Parse(TestList2[4]));
                _goalList.Add(AGoal);
            }
        }
        
        // foreach (Goal item in Goals){
        //     _goalList.Add(item);
        // }
    // return Goals;
    }

    public void AddNewGoal(string NewGoalString, Goal NewGoal){
        _stringGoalList.Add(NewGoalString);
        _goalList.Add(NewGoal); 
    }

    public void RemoveCompletedGoal(){
        // This will be used and called if a goal item's completion status is marked as true.
        // It will cause the 
    }
    public void GoalsToRecord(List<string> Goals){
        // Alright, this method will take the contents of a list and put it into a recordable file.
        string RecordThis = "";
        foreach (string goal in Goals){
            // MiddleMan = RecordThis;
            RecordThis = $"{RecordThis}\n{goal}";
        }
        string FileName = "GoalStorage.txt";
        using (StreamWriter OutputFile = new StreamWriter(FileName)){
            OutputFile.WriteLine(RecordThis);
        }
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);

        Console.WriteLine();
        Console.Write("Saving");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        
        Console.WriteLine("Your goals were saved.\nPress the Enter key to continue.");
        Console.ReadLine();
        Console.Clear();
    }
}