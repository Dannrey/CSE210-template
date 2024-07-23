public class RunningActivity : Activity{
    // Attributes:
    // private float _distanceRan;


    // Constructors:
    public RunningActivity(){
        Console.WriteLine("You have selected Running Activity.\nI will ask you about the amount of time spent running along with the total distance you ran.\nMeasurements will be in the metric system.");
        _activityType = "run";
        SetDate();
        SetDuration();
        SetDistance();
    }


    // Methods:
    public override void SetDistance(){
        Console.Write("Please enter the number of miles ran today (in kilometers): ");
        _distance = int.Parse(Console.ReadLine());
        // And, because the other
        SetPace();
        SetSpeed();
    }
    public override void SetPace(){
        _pace = _minutes/_distance;
    }
    public override void SetSpeed(){
        _speed = 60/_pace;
    }
    // I really won't need anything else to get the other measurements, so I'll just leave it like that.

}