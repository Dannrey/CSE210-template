public class Goal{
    // Attributes:
    private string _goalIntro = "This is the Goal Device (D.G.).\nThe G.D. will help you in the creation of goals.";
    private string _goalInstructions = "";
    private string _goalMenu = "There are three types of goals that you can create:\n\t1.";
    private string _goalOutro = "Congratulations! You have created a new goal!";
    protected string _goalName;
    protected DateTime _goalCreationTime;
    protected DateTime _currentTime;
    private int _pointsForCompletingGoal;
    private int _pointsEarnedThisSession;
    private bool _goalCompletionStatus;

    // Constructors:
    public Goal(){

    }
    public Goal(string PlaceHolder){

    }

    // methods:
    public virtual void MakeNewGoal(){

    }
    public virtual void EarnPoints(){

    }
    public virtual int ReturnPointsEarnedThisSession(){
        return _pointsEarnedThisSession;
    }
    public void MarkGoalComplete(){
        _goalCompletionStatus = true;
    }
}