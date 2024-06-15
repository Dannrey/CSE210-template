/*
File name: BreathingActivityClass.cs
Author: Danniel Reynolds
Date: 06/10/2024 - 06/15/2024
Purpose: Create the BreathingActivity class.
*/


public class BreathingActivity : Activity{
    // Attributes:
    private string _breathingIntro = "Welcome to the breathing activity!\n";
    private string _breathingOutroP1 = "Congratulations. You have successfully completed about ";
    private string _breathingOutroP2 = " seconds of the breathing activity.";
    private string _breathingInstructions = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.\nYou will begin the activity on the beep.\nHit the Enter key when you are ready to begin.";


    // Constructors:
    public BreathingActivity(){
        Console.Clear();
        DisplayIntro(_breathingIntro);
        DisplayInstructions(_breathingInstructions);
        Breathe();
        BreathingGuider();
        DisplayOutro(_breathingOutroP1,_breathingOutroP2);
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
            Console.Beep();
            
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
            // Console.Write("\b\b \b\b ");
            // Thread.Sleep(750);
            Thread.Sleep(1000);
            Console.Clear();
            CurrentTime = DateTime.Now;
        } while (CurrentTime != EndTime && CurrentTime < EndTime);
        Console.Clear();
    }
    public void Breathe(){
        SetDuration();
        DisplaySpinner();
        Console.Clear();
        Console.WriteLine("Get ready");
        DisplaySpinner();
        // Thread.Sleep(1000);
    }
}