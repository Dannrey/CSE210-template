public class OutDoorEvent : Event{
    private string _weatherForcast;
    private List<string> _weatherPatterns = new List<string>(["sunny","cloudy","cloudy with a chance of rain","windy","stomy","partially cloudy"]);
    private List<string> _eventTitles = new List<string>(["","Ryan's Birthday Party","Great Northwestern Auction"]);
    private List<string> _eventDescriptions = new List<string>(["",""]);

    public OutDoorEvent(){
        Random random = new Random();
        _weatherForcast = _weatherPatterns[random.Next(0,_weatherPatterns.Count-1)];
        _eventTitle = _eventTitles[random.Next(0,_eventTitles.Count-1)];
    }


    public void FullDetails(){
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Come join us on the {_dateOfEvent}, at {_timeOfEvent}.");
        Console.WriteLine($"The weather forcast for {_dateOfEvent} is {_weatherForcast}.\nPlease dress accordingly.");
        Console.Write("Location:");
        _addressOfEvent.GetAddressString();
        // Console.WriteLine($"Weather forcast for the event {_weatherForcast}");
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
    }
}