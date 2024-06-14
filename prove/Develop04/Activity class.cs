public class Activity {
    // Attributes:
    private string _programIntro = "Hello! I am your W.A.R.D., the Wellness And Relaxation Device.\nMy purpose today is to assist you in relaxing by giving you a selection of activities to choose from.\n";
    private string _programInstructions = "Each run through this program, you will be given a menu with three items to choose from.\nPlease select one of the numeric values associated with each option.\nAfter this, I will then ask you for a time in seconds for how long the activity will last, if applicable.\nEach activity will also have instructions that will be displayed each time you select it.\nHit the Enter key when you are ready to move on:\n";
    private string _programMenu = "Menu Options:\n\t1. Start breathing activity\n\t2. Start reflection activity\n\t3. Start listing activity\n\t4. Quit\nSelect a choice from the menu: ";
    protected int _duration = 30;
    private string _activitySelection = "Not 4";
    private string _programOutro = "Thanks for using my activities. I hope this helped you get relaxed!\nCome again soon!";
    protected List<string> _promptList = new List<string>();


    // Constructors:
    public Activity(string placeholder){
        Console.Clear();
        DisplayIntro(_programIntro);
        DisplayInstructions(_programInstructions);
        while (_activitySelection != "4"){
            DisplayMenu();
            // if (_activitySelection == "1" || _activitySelection == "2"){
                // SetDuration();
            // }
            if (_activitySelection == "3"){
                _duration = 30;
            }
            if (_activitySelection != "4"){
                if (_activitySelection == "1" || _activitySelection == "2" || _activitySelection == "3"){
                    RunActivity();
                }
                else{
                    Console.WriteLine("Sorry, that is not a valid option. Please try typing the number listed with the respective activity.\nHit the Enter key to continue:");
                    Console.ReadLine();
                }
            }
        }
        DisplayOutro(_programOutro,"");
        // DisplayMenu();
    }
    public Activity(){
    }


    // Methods:
    public void DisplayIntro(string Intro){
        Console.WriteLine(Intro);
    }
    public void DisplayInstructions(string instructions){
        Console.Write(instructions);
        Console.ReadLine();
        Console.Clear();
    }
    public void DisplayMenu(){
        Console.Write(_programMenu);
        _activitySelection = Console.ReadLine();
    }
    public void SetDuration(int Duration){
        _duration = Duration;
    }
    public void DisplaySpinner(){
        int iteration = 0;
        Console.Write(" ");
        while (iteration != 20){
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b/");
            Thread.Sleep(125);
            Console.Write("\b-");
            Thread.Sleep(125);
            Console.Write("\b\\");
            Thread.Sleep(125);
            Console.Write("\b|");
            Thread.Sleep(125);
            Console.Write("\b/");
            Thread.Sleep(125);
            Console.Write("\b-");
            Thread.Sleep(125);
            Console.Write("\b\\\b");
            Thread.Sleep(125);
            iteration += 1;
        }
        Console.Write(" ");
    }
    public void RunActivity(){
        if (_activitySelection == "1"){
            Console.Clear();
            BreathingActivity SelectedActivity = new BreathingActivity();
        }
        else if (_activitySelection == "2"){
            Console.Clear();
            ReflectionActivity SelectedActivity = new ReflectionActivity();
        }
        else if (_activitySelection == "3"){
            Console.Clear();
            // ListingActivity SelectedActivity = new ReflectingActivity();
        }
    }
    public void DisplayOutro(string OutroP1, string OutroP2){
        if (_activitySelection == "4"){
            Console.WriteLine(OutroP1);
        }
        else{
            Console.WriteLine(OutroP1+_duration+OutroP2);
        }
    }
    public void DisplayPrompt(){
        
    }


}