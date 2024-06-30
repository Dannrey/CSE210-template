public class Goal{
    // Attributes:
    protected string _goalName;
    protected DateTime _goalCreationTime;
    protected int _pointsForCompletingGoal;
    protected bool _goalCompletionStatus;

    // Constructors:
    public Goal(){
        MakeNewGoal();
    }
    public Goal(string PlaceHolder){

    }
    public Goal(string GoalName,DateTime GoalCreationTime, int PointsEarnedForCompletingGoal,bool GoalCompletionStatus){
        _goalName = GoalName;
        _goalCreationTime = GoalCreationTime;
        _pointsForCompletingGoal = PointsEarnedForCompletingGoal;
        _goalCompletionStatus = GoalCompletionStatus;
    }

    // methods:
    public virtual void MakeNewGoal(){
        Console.WriteLine("What is the goal?");
        _goalName = Console.ReadLine();


        string response;
        bool Redo;
        do{
            Console.Write("Please enter one of the point value options for completing the goal:\n\t100\n\t200\n\t500\n");
            response = Console.ReadLine();
            if (response == "100" || response == "200" ||response == "500"){
                _pointsForCompletingGoal = int.Parse(response);
                Console.Clear();
                Redo = false;
            }
            else{
                Console.Write("I'm sorry, that is not a valid option.\nPlease try again.");
                Console.ReadLine();
                Console.Clear();
                Redo = true;
            }
        } while (Redo == true);
        _goalCreationTime = DateTime.Now;
    }
    public virtual int EarnPoints(){
        return _pointsForCompletingGoal;
    }

    public virtual int MarkGoalComplete(){
        _goalCompletionStatus = true;
        return _pointsForCompletingGoal;
    }

}