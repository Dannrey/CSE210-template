public class BreathingActivity : Activity{
    // Attributes:
    private string _breathingIntro = "Welcome to the breathing activity!\n";
    private string _breathingOutroP1 = "Congratulations. You have successfully completed about ";
    private string _breathingOutroP2 = " seconds of the breathing activity.";
    private string _breathingInstructions = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.\n";


    // Constructors:
    public BreathingActivity(){
        Console.Clear();
        DisplayIntro(_breathingIntro);
        DisplayInstructions(_breathingInstructions);
        Breathe();
        BreathingGuider();
        DisplayOutro(_breathingOutroP1,_breathingOutroP2);
        Console.Write("Hit the Enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();
    }


    // Methods:
    public void BreathingGuider(){
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_duration);
        DateTime CurrentTime = DateTime.Now;
        // int x = 0;
        do{   // Note to self, fix this so that it doesn't use as many if statements and will just cycle through all of the code at once. Then one breath would not be incomplete.
            // if (x < 3){
                // if (x == 0){
            Console.Clear();
            Console.WriteLine("Breathe in");
                // }
            // x += 3;
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);
            Console.Write("--");
            Thread.Sleep(125);

            Console.Clear();
            Console.WriteLine("Hold it");
            Console.Write("================================================");
            Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Exhale");
            Console.Write("------------------------------------------------");

            Console.Write("\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            Thread.Sleep(125);
            Console.Write("\b\b \b\b ");
            // Thread.Sleep(125);
            Thread.Sleep(1000);
            Console.Clear();
            CurrentTime = DateTime.Now;
        } while (CurrentTime != EndTime && CurrentTime < EndTime);
        Console.Clear();
    }
    public void Breathe(){
        Console.Write("How long, in seconds, would you like for your session to be? ");
        int Duration = int.Parse(Console.ReadLine());
        SetDuration(Duration);
    }
}