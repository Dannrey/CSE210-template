/*
File name: ReflectionActivityClass.cs
Author: Danniel Reynolds
Date: 06/10/2024 - 06/15/2024
Purpose: Create the ReflectingActivity class.
*/

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public class ReflectionActivity : Activity{
    // Attributes:
    private string _reflectionIntro = "Welcome to the reflecting activity!\n";
    private string _reflectionInstructions = "This activity will help you reflect on previous experiences and draw more meaning from them.\nHit the Enter key to continue.\n";
    private string _programOutroP1 = "Congratulations. You have successfully completed about ";
    private string _programOutroP2 = " seconds of the reflection activity.";
    private List<string> _questionList = new List<string>(["What was your favorite thing that happened to you?","What is the worst thing that happened to you?","What was the nicest thing someone did for you?","What was the nicest thing that you did for someone else?","What was your favorite thing that you did?","Did you feel the Spirit?","Why was this experience meaningful to you?","How did you get started?","How did you feel when it was complete?","What is your favorite thing about this experience?","Was there anything you could have done better?","What was the greatest part about it?"]);
    private List<string> _promptList = new List<string>(["Think about your last birthday.","Think about last Christmas.","Think about the last General Conference.","Think about the last time you went on vacation.","Think about the last time you saw your best friend.","Think about yesterday.","Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."]);


    // Constructors:
    public ReflectionActivity(){
        DisplayIntro(_reflectionIntro);
        DisplayInstructions(_reflectionInstructions);
        SetDuration();
        DisplayPrompt();
        DisplayQuestions();
        Console.Clear();
        DisplayOutro(_programOutroP1,_programOutroP2);
    }


    // Methods:
    public void DisplayQuestions(){
        Random random = new Random();
        string Question;
        DateTime CurrentTime = DateTime.Now;
        DateTime EndTime = CurrentTime.AddSeconds(_duration);
        List<string> Questions = new List<string>();
        foreach (string item in _questionList){
            Questions.Add(item);
        }
        int QuestionIndex;
        do{
            QuestionIndex = random.Next(0,Questions.Count-1);
            Question = Questions[QuestionIndex];
            Questions.Remove(Questions[QuestionIndex]);
            Console.WriteLine(Question);
            Thread.Sleep(5000);
            CurrentTime = DateTime.Now;
            if (Questions.Count == 0){
                Console.WriteLine("I'm sorry, but I ran out of questions for you.");
                break;
            }
            // CurrentTime = DateTime.Now;
        } while (CurrentTime != EndTime && CurrentTime < EndTime);
        Console.WriteLine("Hit the Enter key to continue:");
        Console.ReadLine();
    }
    public void DisplayPrompt(){   // I would rather put this function inside the main program because it is used in two of the child classes.
        Random random = new Random();
        int PromptIndex = random.Next(0,_promptList.Count-1);
        string Prompt = _promptList[PromptIndex];
        Console.WriteLine(Prompt);
    }
}