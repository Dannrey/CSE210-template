using System.Collections.Generic;
// using System.Security.Cryptography;
public class UserInteractions{
    // Attributes:
    private List<Goal> _goalList = new List<Goal>();
    private List<string> _stringGoalList = new List<string>();
    private int _points = 0;  // Alright. I figured out how to bypass that last error message that was giving me grief. I went and defined a new variable here that return the total number of points earned by the user.


    // Constructors:
    public UserInteractions(){
        StockGoalItems();
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
    public void StockGoalItems(){
    /*Okay. This method will take the contents of a text file and turn it into */
        string FileName = "GoalStorage.txt";
        string[] lines = System.IO.File.ReadAllLines(FileName);

        List<Goal> Goals = new List<Goal>();
        List<string> GoalStrings = new List<string>();
        foreach(string line in lines){
            GoalStrings.Add(line.Trim());
            // string[] parts = line.Split(":");
        }
        string TestVariable;
        List<string> TestList;
        List<string> TestList2;
        foreach (string i in GoalStrings){
            TestList = new List<string>(i.Split(","));

            TestVariable = TestList[1];

            TestList2 = new List<string>();

            TestList2.Add(TestVariable);

            if (TestList[0].ToLower() == "goal"){
                Goal AGoal = new Goal(TestList[1],DateTime.Parse(TestList[2]),int.Parse(TestList[3]),bool.Parse(TestList[4]));
                _goalList.Add(AGoal);
                _stringGoalList.Add(AGoal.GetClassRepresentation());
            }
            // else if (TestList[0].ToLower() == "simplegoal"){}
            else if (TestList[0].ToLower() == "listgoal"){
                ListGoal AGoal = new ListGoal(TestList[1],DateTime.Parse(TestList[2]),int.Parse(TestList[3]),bool.Parse(TestList[4]),int.Parse(TestList[5]),int.Parse(TestList[6]),int.Parse(TestList[7]));
                _goalList.Add(AGoal);
                _stringGoalList.Add(AGoal.GetClassRepresentation());
            }
            else if (TestList[0].ToLower() == "longtermgoal"){
                LongtermGoal AGoal = new LongtermGoal(TestList[1],DateTime.Parse(TestList[2]),int.Parse(TestList[3]),bool.Parse(TestList[4]));
                _goalList.Add(AGoal);
                _stringGoalList.Add(AGoal.GetClassRepresentation());
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
    public void RecordRunningGoals(){
        string fileName = "GoalStorage.txt";
        using (StreamWriter OutputFile = new StreamWriter(fileName)){
            foreach (string goal in _stringGoalList){
                OutputFile.WriteLine(goal);
            }
        }
    }

    public int MarkGoalComplete(string complete){

        List<string> characterList;
        // int iteration = 1;
        Console.WriteLine($"Which goal from the list do you want to {complete}?");
        // string item;
        foreach (string item in _stringGoalList){
            characterList = new List<string>(item.Split(","));
            Console.WriteLine($"-{characterList[1]}");
            characterList.Clear();
        }

        Console.Write("Please select one goal from the list by entering its name: ");
        string goalName = Console.ReadLine();
        Console.Clear();
        

        // Console.Write("Are you dropping it or completing it (enter drop or complete)? ");
        // string completionStatus = Console.ReadLine();
        // Console.Clear();

        // int iteration = 0;
        // int iteration;
        string stringVariable;
        if (complete.ToLower() == "terminate"){
            foreach (string j in _stringGoalList){
                List<string> characterList2 = new List<string>(j.Split());
                if (characterList2[1].ToLower() == goalName){
                    stringVariable = goalName;
                    _stringGoalList.Remove(goalName);
                    _points = 0;
                }
                // iteration += 1;
            }
        }
        else if (complete.ToLower() == "complete"){
            foreach (string j in _stringGoalList){
                List<string> characterList2 = new List<string>(j.Split(","));
                if (characterList2[1] == goalName){
                    if (characterList2[0] == "LongTermGoal"){
                        LongtermGoal goal = new LongtermGoal(characterList2[1],DateTime.Parse(characterList2[2]),int.Parse(characterList2[3]),bool.Parse(characterList2[4]));//0],characterList2[1],characterList2[2]){//,characterList2[3],characterList2[4],characterList2[5],characterList2[6],characterList2[7],characterList2[8],characterList2[9],characterList2[10]);
                        _points = goal.MarkGoalComplete();
                    }
                    else if (characterList2[0] == "Goal"){
                        Goal goal = new Goal(characterList2[1],DateTime.Parse(characterList2[2]),int.Parse(characterList2[3]),bool.Parse(characterList2[4]));
                        _points = goal.MarkGoalComplete();
                    }
                    else if (characterList2[0] == "ListGoal"){
                        ListGoal goal = new ListGoal(characterList2[1],DateTime.Parse(characterList2[2]),int.Parse(characterList2[3]),bool.Parse(characterList2[4]),int.Parse(characterList2[5]),int.Parse(characterList2[6]),int.Parse(characterList2[7]));
                        _points = goal.MarkGoalComplete();
                    }
                    _stringGoalList.Remove(j);
                    // _goalList.Remove();
                }
            }
        }
        return _points;  // I don't know what the problem with this here is, but it is holding up the program.
    }
    public void GoalsToRecord(){//List<string> Goals){
        // Alright, this method will take the contents of a list and put it into a recordable file.
        // foreach (Goal g in _goalList){
        //     _stringGoalList.Add(g.GetClassRepresentation());
        // }
        string RecordThis = "";  
        /* I remember what this variable does. 
        It is initialized as an empty variable because it needs to become whatever is in the formatted string below, 
        and if it starts empty than it will add nothing to be recorded at first, but will gain value later.*/
        foreach (string goal in _stringGoalList){
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