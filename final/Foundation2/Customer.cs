public class Customer{
    private string _name;
    private Address _address = new Address(){};
    private List<string> _names = new List<string>(["Carl Welcher","Dave Filoni","Fredrick Fredrickson","Lillian Paul","Anna Jackson","Emily Smith"]);

    public Customer(){
        Random random = new Random();
        _name = _names[random.Next(0,_names.Count - 1)];
    }
    public void PrintName(){
        Console.WriteLine($"Name: {_name}");

    }
    public bool ConveyUSResidencyStatus(){
        return _address.GetUSResidencyStatus();
    }
    public void ConveyAddress(){
        _address.GetAddressString();
    }
}