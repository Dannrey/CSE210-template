public class Activity{
    // Attributes:
    protected DateTime _date;
    protected int _minutes;   // in minutes
    // protected string _measurementType;
    protected string _activityType;
    protected float _distance;
    protected float _speed;
    protected float _pace;
    // protected int 


    // Constructors:
    public Activity(){
        /*Alrighty then. I have my base attributes defined, so now I'll just need to make virtual and override classes.*/
        // Console.WriteLine("");
    }


    // Methods:
    public void SetDuration(){
        Console.Write("Please enter the amount of time spent on this exercise (in minutes): ");
        _minutes = int.Parse(Console.ReadLine());
    }
    public virtual void SetDistance(){
    }  // Each of these are going to be called into use.
    public virtual void SetPace(){
    }  // Each of these are going to be called into use.
    public virtual void SetSpeed(){
    }  // Each of these are going to be called into use.
    public void SetDate(){
        // DateTime dateTime = new DateTime();
        _date = DateTime.Now;

        // _date = dateTime.ToLongDateString();
    }
    public void PrintSummaryString(){
        Console.WriteLine($"{_date} {_activityType} ({_minutes} minutes)- Distance Covered: {_distance} kilometers, Average Speed: {_speed} kph, Average Pace: {_pace} minutes per kilometer");
    }


}