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
        bool Continue = true;
        do{
            Console.Write("How many times do you want to complete this? ");
            response = Console.ReadLine();
            foreach (string character in response.Split("")){
                if (Char.IsNumber(response,0) == false){
                    Continue = false;
                    Console.Write("I'm sorry, that is not a valid option.\nPlease try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else {
                    Continue = true;
                    Console.Clear();
                }
            }
        } while (Continue == false);
        _lengthOfGoal = int.Parse(response);
    }
    public override int MarkGoalComplete(){
        _completedGoalSections += 1;  // This will mark one of the list goals complete.
        int PointsEarned = 0;  // The idea of this is to return how many points will be earned when the goal is complete.
        if (_completedGoalSections < _lengthOfGoal){   // This if sttement will check if the entire goal lis complete or not, and will deliver a different result based on that.
            PointsEarned = _pointsForCompletingGoal;
        }
        else if (_completedGoalSections == _lengthOfGoal){
            PointsEarned = _pointsForCompletingGoal + _completedGoalBonus;
            _goalCompletionStatus = true;
            Console.WriteLine($"ongratulations!\nYou completed your goal and earned {_completedGoalBonus} bonus points for completing the netire goal.");
        }
        return PointsEarned;
    }
    // public override 
}