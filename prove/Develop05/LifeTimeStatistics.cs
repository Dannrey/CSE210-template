
public class LifetimeStatistics{
    // Attributes:
    private int _runningGoals;
    private int _completedGoals;
    private int _totalGoalsSet;
    private int _lifetimePoints;


    // Constructors:
        
    public LifetimeStatistics(){
        string FileName = "LifetimeStatistics.txt";
        string[] lines = System.IO.File.ReadAllLines(FileName);
        foreach (string line in lines){
            // List<string> PartList= new List<string>();
            string[] parts = line.Split(",");
            _runningGoals = int.Parse(parts[0]);
            _completedGoals = int.Parse(parts[1]);
            _totalGoalsSet = int.Parse(parts[2]);
            _lifetimePoints = int.Parse(parts[3]);
        
        }
    }


    // Methods:
    public void AddNewCompletedGoal(){
        _completedGoals += 1;
        _runningGoals -= 1;
    }
    public void AddNewRunningGoal(){
        _runningGoals += 1;
        _totalGoalsSet +=1;
    }
    public void DisplayLifetimeStatistics(){
        Console.Clear();
        Console.WriteLine($"Total goals set: {_totalGoalsSet}");
        Console.WriteLine($"Completed goals: {_completedGoals}");
        Console.WriteLine($"Currently running goals: {_runningGoals}");
        Console.WriteLine($"Lifetime points earned: {_lifetimePoints}");
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();
    }
    public void AddPoints(int Point){
        _lifetimePoints += Point;
    }
    public void StoreCurrentStatistics(){
        string FileName = "LifetimeStatistics.txt";

        using (StreamWriter OutputFile = new StreamWriter(FileName)){
            OutputFile.Write($"{_runningGoals},{_completedGoals},{_totalGoalsSet},{_lifetimePoints}");
        }
    }
}