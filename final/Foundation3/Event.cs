public class Event{
    // Attributes:
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _dateOfEvent;
    protected string _timeOfEvent;
    protected Address _addressOfEvent = new Address();
    protected string _eventType;
    protected List<string> _dateList = new List<string>(["Oct/07/2025","Jan/05/2016","May/19/1976"]);
    protected List<string> _timeList = new List<string>(["12:30 PM","16:15","8:00 AM"]);
    // private List<string> _List = new List<string>([]);
    // private List<string> _List = new List<string>([]);
    // private List<string> _List = new List<string>([]);

    // Constructors:
    public Event(){

    }


    // Methods:
    public void StandardDetails(){
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Come join us on the {_dateOfEvent}, at {_timeOfEvent}.");
        Console.Write("Location:");
        _addressOfEvent.GetAddressString();
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
    }
    // public void FullDetails(){

    // }
    public void ShortDescription(){

    }
    public void BriefDescription(){
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Event classification: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"On the {_dateOfEvent}, at {_timeOfEvent}");
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
    }


}