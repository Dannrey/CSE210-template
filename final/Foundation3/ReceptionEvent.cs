public class ReceptionEvent : Event{
    // Attributes:
    private List<string> _guestList = new List<string>(["Danniel Reynolds","Ryan Rogue","Kate Devinham","Tyler Kirn"]);
    private string _rsvpEmailAddress;
    private int _numberOfSeats;
    private List<string> _emailAddresses = new List<string>(["RegisterNow@gmail.com","Register.Now@aol.com","Registration@outlook.com"]);
    private List<string> _titles = new List<string>(["Ryan's Birthday Party","Dreamworks Through the Ages","Meet your favorite Author (Brandon Mull)"]);  // Even thought this attribute name is shared by each of tthe subclasses, I have it with different contents for each of the subclasses.
    private List<string> _descriptions = new List<string>(["Celebrate with cake!","Time to party!"]);
    // private List<string> _titles = new List<string>([]);

    // Constructors:
    public ReceptionEvent(){
        Random random = new Random();
        // _rsvpEmailAddress = _emailAddresses[random.Next(0,_emailAddresses.Count - 1)];
        // _timeOfEvent = _timeList[random.Next(0,_timeList.Count - 1)];
        // _dateOfEvent = _dateList[random.Next(0,_dateList.Count - 1)];
        _numberOfSeats = random.Next(50,500);
        // Console.WriteLine($"There are currently {_numberOfSeats-_guestList.Count}/{_numberOfSeats} available.");
        // _speaker = _speakers[random.Next(0,_speakers.Count-1)];
        // _dateOfEvent = _dateList[random.Next(0,_dateList.Count-1)];
        // _timeOfEvent = _timeList[random.Next(0,_dateList.Count-1)];
        // _eventDescription = _descriptions[random.Next(0,_descriptions.Count-1)];
        // _eventTitle = _titles[random.Next(0,_titles.Count-1)];
        _eventType = "Reception";
        GetDetails();
        GetSpecificDetails();
    }
    public void GetSpecificDetails(){
        Console.Write("To attend this event, guests must register for it in advance.\nWhat is the RSVP email address? ");
        _rsvpEmailAddress = Console.ReadLine();

    }


    // Methods:
    public void FullDetails(){
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Come join us on {_dateOfEvent}, at {_timeOfEvent}.");
        Console.WriteLine($"The email to register is {_rsvpEmailAddress}.");
        Console.WriteLine($"There are currently {_numberOfSeats-_guestList.Count}/{_numberOfSeats} available. Sign up while there is still time!");
        Console.WriteLine($"Current amount of guests: {_guestList.Count}");
        // Console.Write("Location:");
        _addressOfEvent.GetAddressString();
        Console.WriteLine("<<<<<<<<<<<<<<<<<-------->>>>>>>>>>>>>>>>>");
    }
    public void AddGuest(){
        Console.Write("Please insert the name of the new guest:");
        string NewGuest = Console.ReadLine();
        Console.WriteLine($"{NewGuest} has been added to the guest list.");
    }

}