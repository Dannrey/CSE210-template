public class Address{
    // Attributes:
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    // private int _zipCode;  // I just realized, the zip code would be dependant on the country so I'll just ignore this.
    // These string lists are meant for randomizing information:
    private List<string> _countries = new List<string>(["U.S.","Russia","Brazil","U.K.","France"]);
    

    // Constructors:
    public Address(){
        Random random = new Random();
        // _zipCode = Random.Next(10000,99999);

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
    public string GetAddressString(){
        return $"{_streetAddress},{_state},{_country}";
    }
}