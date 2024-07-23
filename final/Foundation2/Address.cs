public class Address{
    // Attributes:
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    // private List<string> _countries = new List<string>(["U.S.","Canada","Solomon Islands"]);  // This is most unfortunate. I really liked this bit of code here in that it was all randomized, and is really just showing the outline of what the program is supposed to do.
    // private List<string> _states = new List<string>(["Virgina","Texas","Pennsylvania","Ohio","New York"]);
    // private List<string> _streetAddressess = new List<string>(["1234 Generic Drive","7567 Star Lane","1111 Washington Street"]);
    /* In case you are paying attention to details, the only city that I have here is called Nineveh. 
    Somehow, there are nearly half a dozen cities inside the U.S. alone that are named that, 
    along with one in canada and the Solomon Islands. I think it fits perfectly into this and reduces 
    the complications that could arise from having the program call the name of a city from a particular state, territory, or country.*/


    // Constructors:
    public Address(){
        // Random random = new Random();
        Console.Write("What is the residency country of the client? ");
        _country = Console.ReadLine();
        // _country = _countries[random.Next(0,_countries.Count-1)];
        if (GetUSResidencyStatus() == true){
            Console.Write("Which state does the client live in? ");
            _state = Console.ReadLine();
            // _state = _states[random.Next(0,_states.Count-1)];
        }
        else if (GetUSResidencyStatus() == false){
            if (_country == "Canada"){
                Console.Write("Which Canadian territory does the client live in? ");
                _state = Console.ReadLine();
                // _state = "Nova Scotia";
            }
            else{
                _state = "N/a";
            }
        }
        Console.Write("What city does the client live in? ");
        _city = Console.ReadLine();
        Console.Write("What is the client's street address? ");
        _streetAddress = Console.ReadLine();
        // _streetAddress = _streetAddressess[random.Next(0,_streetAddressess.Count-1)];
    }


    // Methods:
    public bool GetUSResidencyStatus(){
        bool USResidencyStatus;
        string country = _country.Trim();
        if (country.ToUpper() == "US" || country.ToUpper() == "USA" || country.ToUpper() == "U.S." || country.ToUpper() == "U.S.A." || country.ToUpper() == "UNITED STATES" || country.ToUpper() == "UNITED STATES OF AMERICA"){
            USResidencyStatus = true;
        }
        else {
            USResidencyStatus = false;
        }
        return USResidencyStatus;
    }
    public void GetAddressString(){
        Console.WriteLine($"\nAddress:\n{_streetAddress}\n{_city}, {_state}, {_country}");
    }
}