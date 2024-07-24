public class LongtermGoal : Goal{
    // Cosntructors:

    public LongtermGoal(){}
    public LongtermGoal(string GoalName,DateTime GoalCreationTime, int PointsEarnedForCompletingGoal,bool GoalCompletionStatus){
        _goalName = GoalName;
        _goalCreationTime = GoalCreationTime;
        _pointsForCompletingGoal = PointsEarnedForCompletingGoal;
        _goalCompletionStatus = GoalCompletionStatus;
    }
    public override void MakeNewGoal(){
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
    public override int EarnPoints(){
        return _pointsForCompletingGoal;
    }
    public override string GetClassRepresentation(){
        string goalRepresentation = $"Goal,{_goalName},{_goalCreationTime},{_pointsForCompletingGoal},{_goalCompletionStatus},0,0,0";
        return goalRepresentation;
    }
    public override int MarkGoalComplete(){
        _goalCompletionStatus = true;
        return 0;
    }
}