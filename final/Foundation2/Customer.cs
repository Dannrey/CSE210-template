public class Customer{
    private string _name;
    private Address _address = new Address();
    // private List<string> _names = new List<string>(["Carl Welcher","Dave Filoni","Fredrick Fredrickson","Sean Hernandez","Emily Smith","John Doe","Danniel Reynolds",""]);

    public Customer(){
        // Random random = new Random();
        // GetAddressInformation();
        Console.Write("What is the name of the client? ");
        _name = Console.ReadLine();
        Console.Clear();
        // _name = _names[random.Next(0,_names.Count - 1)];
    }
    public void PrintName(){
        Console.WriteLine($"Name: {_name}");

    }
    public bool ConveyUSResidencyStatus(){
        bool Answer = _address.GetUSResidencyStatus();
        return Answer;
    }
    public void ConveyAddress(){  // This here is the exact reason why you want to be careful with getters and setters. If you aren't careful, you'll soon end up with a gregorian knot (was it gregorian? I don't remember exactly, but I know what I mean) to untie to find the sorce of a problem
        _address.GetAddressString();
    }
    public void GetAddressInformation(Address address){
        _address = address;
    }
}