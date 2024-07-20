public class BikingActivity : Activity{
    // Attributes:
    // private float _bikingSpeed;


    // Constructors:
    public BikingActivity(){
        _activityType = "biking";
        Console.WriteLine("You have selected Biking Activity. I will ask you about the amount of time spent biking along with the total distance you biked.\nMeasurements will be in the metric system.");
        SetDuration();
        SetSpeed();
        SetDate();
        // SetDistance();
        // SetPace();
    }


    // Methods:
    public override void SetSpeed(){
        Console.Write("What was the average speed given by the stationary bike device? ");
        _speed = float.Parse(Console.ReadLine());
        SetDistance();
        SetPace();
    }
    public override void SetDistance(){
        _distance = _minutes*_speed;
    }
    public override void SetPace(){
        _pace = 60/_speed;
    }

}