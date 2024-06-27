public class Goal{
    // Attributes:
    protected string _goalName;
    protected DateTime _goalCreationTime;
    protected int _pointsForCompletingGoal;
    protected bool _goalCompletionStatus;

    // Constructors:
    public Goal(){

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

    }
    public virtual int EarnPoints(){
        return _pointsForCompletingGoal;
    }

    public virtual int MarkGoalComplete(){
        _goalCompletionStatus = true;
        return _pointsForCompletingGoal;
    }

}