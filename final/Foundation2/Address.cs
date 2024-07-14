public class Address{
    // Attributes:
    private string _streetAddress;
    private string _city = "nineveh";
    private string _state;
    private string _country;
    private List<string> _countries = new List<string>(["U.S.","Canada","Solomon Islands"]);
    private List<string> _states = new List<string>(["Virgina","Texas","Pennsylvania","Ohio","New York"]);
    private List<string> _streetAddressess = new List<string>(["1234 Generic Drive","7567 Star Lane","1111 Washington Street"]);
    /* In case you are paying attention to details, the only city that I have here is called Nineveh. 
    Somehow, there are nearly half a dozen cities inside the U.S. alone that are named that, 
    along with one in canada and the Solomon Islands. I think it fits perfectly into this and reduces 
    the complications that could arise from having the program call the name of a city from a particular state, territory, or country.*/


    // Constructors:
    public Address(){
        Random random = new Random();
        _country = _countries[random.Next(0,_countries.Count-1)];
        if (GetUSResidencyStatus() == true){
            _state = _states[random.Next(0,_states.Count-1)];
        }
        else if (GetUSResidencyStatus() == false){
            if (_country == "Canada"){
                _state = "Nova Scotia";
            }
            else{
                _state = "N/a";
            }
        }
        _streetAddress = _streetAddressess[random.Next(0,_streetAddressess.Count-1)];
    }


    // Methods:
    public bool GetUSResidencyStatus(){
        bool USResidencyStatus;
        if (_country.ToUpper() == "US" || _country.ToUpper() == "USA" || _country.ToUpper() == "U.S." || _country.ToUpper() == "U.S.A." || _country.ToLower() == "united states" || _country.ToLower() == "united states of america"){
            USResidencyStatus = true;
        }
        else {
            USResidencyStatus = false;
        }
        return USResidencyStatus;
    }
    public void GetAddressString(){
        Console.WriteLine($"{_streetAddress}, {_city}, {_state}, {_country}");
    }
}