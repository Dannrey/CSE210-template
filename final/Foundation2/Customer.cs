public class Customer{
    private string _name;
    private Address _address = new Address(){};
    private List<string> _names = new List<string>(["Carl Welcher","Dave Filoni","Fredrick Fredrickson","Lillian Paul","Anna Jackson","Emily Smith"]);

    public Customer(){
        Random random = new Random();
        _name = _names[random.Next(0,_names.Count - 1)];
    }
}