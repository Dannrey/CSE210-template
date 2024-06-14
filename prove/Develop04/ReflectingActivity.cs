public class ReflectionActivity : Activity{
    // Attributes:
    private string _reflectionIntro = "Welcome to the reflecting activity!";
    private string _reflectionInstructions = "This activity will help you reflect on previous experiences and draw meaning from them.";
    private string _programOutroP1 = "Congratulations. You have successfully completed ";
    private string _programOutroP2 = " seconds of the reflection activity.";
    private List<string> _questionList = new List<string>(["What was your favorite thing that happened to you today?","What is the worst thing that happened to you?","What was the nicest thing someone did for you today?","What was the nicest thing that you did for someone today?","What is a time the you showed strength in the face of opposition?","What was your favorite thing that you did today?"]);


    // Constructors:
    public ReflectionActivity(){
        DisplayIntro(_reflectionIntro);
        DisplayInstructions(_reflectionInstructions);

        DisplayPrompt();
        DisplayQuestions();
        DisplayOutro(_programOutroP1,_programOutroP2);
        Console.Write("Hit the Enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();
    }


    // Methods:
    public void DisplayQuestions(){
        Console.Clear();
        Console.Write("How long, in seconds, would you like for your session to be? ");
        int Duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Random random = new Random();
        string Question;
        DateTime CurrentTime = DateTime.Now;
        DateTime EndTime = CurrentTime.AddSeconds(_duration);
        List<string> Questions = new List<string>();
        Questions = _questionList;
        do{
            // CurrentTime = DateTime.Now;
            
            int QuestionIndex = random.Next(0,Questions.Count-1);
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

        
    }
}