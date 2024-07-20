public class SwimmingActivity : Activity{
    // Attributes:
    private float _numberOfLaps;


    // Constructors:
    public SwimmingActivity(){
        _activityType = "swim";
        Console.WriteLine("You have selected Swimming Activity.\nI will ask you about the amount of time spent swimming along with the total distance you ran.\nMeasurements will be in the metric system.");
        SetDuration();
        SetDate();
        SetDistance();
    }

    public override void SetDistance(){
        Console.Write("What is the number of laps completed? ");
        _numberOfLaps = float.Parse(Console.ReadLine());
        _distance = _numberOfLaps*50/1000;
        // _speed = _distance/_minutes;
        // _pace = _speed/60;
        SetPace();
        SetSpeed();
    }
    public override void SetPace(){
        _pace = _minutes/_distance;
    }
    public override void SetSpeed(){
        _speed = 60/_pace;
    }
}