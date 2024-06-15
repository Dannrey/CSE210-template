/*
File name: ListingActivityClass.cs
Author: Danniel Reynolds
Date: 06/10/2024 - 06/15/2024
Purpose: Create the ListingActivity class.
*/


public class ListingActivity : Activity{
    // Attributes:
    private string _listingIntro = "Welcome to the Listing Activity!\n";
    private string _listingInstructions = "This activity will help you reflect on the good things in your life by having you focus on listing things\nrelating to a specific area.\nYou will begin listing items at the beep.\nHit the Enter key when you are ready to continue.";
    private string _listingOutroP1 = "Congratulations. You have successfully completed ";
    private string _listingOutroP2 = " seconds of the listing activity.";
    private List<string> _promptList = new List<string>(["Think about a time when you felt the spirit.","Think of a time when you did something nice for another.","Think of a time when you had lots of fun.","Think of a time when somebody did something nice for you."]);
    // private List<string> _gratitudeList = new List<string>();


    // Constructors:
    public ListingActivity(){
        DisplayIntro(_listingIntro);
        // DisplaySpinner();
        DisplayInstructions(_listingInstructions);
        // DisplaySpinner();
        SetDuration();
        DisplaySpinner();
        Console.Clear();
        Console.WriteLine("Focus on the following prompt and times and events that it makes you think of:");
        DisplayPrompt();
        GetGratitudeList();
        DisplaySpinner();
        DisplayOutro(_listingOutroP1,_listingOutroP2);
    }


    // Methods:
    public void DisplayPrompt(){
        // List<string> prompts = new List<string>();
        // prompts = _promptList;
        // List<string> Prompts = new List<string>();
        // int iteration = 0;
        // while (iteration != 2){
        Random random = new Random();
        int PromptIndex = random.Next(0,_promptList.Count-1);
        string Prompt = _promptList[PromptIndex];
        Console.WriteLine(Prompt);
        // }
    }
    public void GetGratitudeList(){
        List<string> GratitudeList = new List<string>();
        DisplaySpinner();
        Console.Beep();
        DateTime CurrentTime = DateTime.Now;
        DateTime EndTime = CurrentTime.AddSeconds(_duration);
        string GratitudeObject;
        do{
            Console.Write(">");
            GratitudeObject = Console.ReadLine();
            GratitudeList.Add(GratitudeObject);
            CurrentTime = DateTime.Now;
        } while (CurrentTime < EndTime);
        Console.Clear();
        Console.WriteLine($"Excellent! You thought of {GratitudeList.Count} times relating to the prompt.");
    }
}