public class LifetimeStatistics{
    // Attributes:
    private int _runningGoals;
    private int _completedGoals;
    private int _totalGoalsSet;
    private int _lifetimePoints;

    // public void DisplayLifetimePoints(){
    //     Console.WriteLine(_lifetimePoints);
    // }
    public void AddNewCompletedGoal(){
        _completedGoals += 1;
        _runningGoals -= 1;
    }
    public void AddNewRuningGoal(){
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
    }
}