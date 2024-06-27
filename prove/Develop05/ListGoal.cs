public class ListGoal : Goal{
    // Attributes:
    int _lengthOfGoal;
    int _completedGoalSections;
    int _completedGoalBonus;

    // Constructors:
    public ListGoal(){

    }

    public ListGoal(string GoalName,DateTime GoalCreationTime, int PointsEarnedForCompletingGoal,bool GoalCompletionStatus,int LengthOfGoal,int CompletedGoalSections,int CompletedGoalBonus){// : base(string GoalName,DateTime GoalCreationTime, int PointsEarnedForCompletingGoal,bool GoalCompletionStatus){
        _goalName = GoalName;
        _goalCreationTime = GoalCreationTime;
        _pointsForCompletingGoal = PointsEarnedForCompletingGoal;
        _goalCompletionStatus = GoalCompletionStatus;
        _lengthOfGoal = LengthOfGoal;
        _completedGoalSections = CompletedGoalSections;
        _completedGoalBonus = CompletedGoalBonus;
    }
    public void CreateNewGoal(){
        Console.Write("What is the title of this goal? ");
        _goalName = Console.ReadLine();
        Console.Clear();
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
        _completedGoalBonus = _pointsForCompletingGoal*10;
        Console.Write("How many times do you want to complete this? ");
        response = Console.ReadLine();
        // bool _continue = true;
        foreach (string character in response.Split("")){
            if (Char.IsNumber(response,0) == false){
                // _continue = false;
                Console.Write("I'm sorry, that is not a valid option.\nPlease try again.");
                Console.ReadLine();
                Console.Clear();
                break;
            }
        }
        _lengthOfGoal = int.Parse(response);
    }

}