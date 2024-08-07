public class LectureEvent : Event{
    // Attributes:
    private string _speaker;
    private int _numberOfSeats;
    // private List<string> _speakers = new List<string>(["David Tennent","Danniel Reynolds","Thomas S. Monson","John Bytheway","Hank Smith","Matt Meese"]);
    // private List<string> _titles = new List<string>(["Redisputing Albert Einstein's Theory of relativity","Signs of the times","How to play Dungeons & Dragons"]);
    // private List<string> _descriptions = new List<string>(["A thorough inspection and discussion of the laws of physics","A discussion with a modern day prophet."]);
    // Constructors:
    public LectureEvent(){
        Random random = new Random();
        _numberOfSeats = random.Next(50,150);
        // _speaker = _speakers[random.Next(0,_speakers.Count-1)];
        // _dateOfEvent = _dateList[random.Next(0,_dateList.Count-1)];
        // _timeOfEvent = _timeList[random.Next(0,_dateList.Count-1)];
        // _eventDescription = _descriptions[random.Next(0,_descriptions.Count-1)];
        // _eventTitle = _titles[random.Next(0,_titles.Count-1)];
        _eventType = "Lecture";
        GetDetails();

    }

    // Methods:
    public void GetSpecificDetails(){
        Console.WriteLine("What is the name of the speaker at the lecture? ");
        _speaker = Console.ReadLine();
    }
    public void FullDetails(){
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Come join us on {_dateOfEvent}, at {_timeOfEvent}.");
        Console.WriteLine($"There are {_numberOfSeats} seats at the lecture.\nIt will be broadcasted but if you desire to attend in person, please plan accordingly.\nOnce the lecture hall is filled, guests will be redirected to overflow areas where they will watch the live broadcast.");

        // Console.Write("Location: ");
        _addressOfEvent.GetAddressString();
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
    }


}