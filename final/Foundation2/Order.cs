public class Order{
    // Attributes:
    private List<Product> _products = new List<Product>();
    // private Address _address = new Address();
    private Customer _customer = new Customer();


    // Constructors:
    public Order(){
        GenerateProductList();
    }



    // Methods:
    public void GenerateProductList(){
        Random random = new Random();
        List<string> ProductKeys = new List<string>(["A110","A111","A112","A113","A114","A115","A116","A117","A118","A119",]); 
        int ProductsPurchased = random.Next(2,3);
        int iteration = 0;
        string ProductKey;
        while (iteration != ProductsPurchased){
            ProductKey = ProductKeys[random.Next(0,ProductKeys.Count - 1)];
            Product product = new Product(ProductKey);
            _products.Add(product);
            iteration += 1;
        }
    }
    public float GetShippingPrice(){
        float shipping;
        if (_customer.ConveyUSResidencyStatus() == true){
            shipping = 5;
        }
        else {
            shipping = 35;
        }
        return shipping;
    }

    public void PrintPackingLabel(){
        Console.WriteLine("Puchases:\n");
        float TotalPrice = 0;
        foreach (Product product1 in _products){
            product1.PrintPackingLabelInformation();
            TotalPrice += product1.GetPriceOfProduct();
            Console.WriteLine();
        }

        if (_customer.ConveyUSResidencyStatus() == true){
            TotalPrice += 5;
            Console.WriteLine("Shipping Fee: $5");
        }

        else{
            TotalPrice += 35;
            Console.WriteLine("Shipping Fee: $35");
        }

        Console.WriteLine($"Total Price: ${TotalPrice}");
        // Console.WriteLine();
    }
    public void PrintShippingLabel(){
        Console.WriteLine("Shipping Information:");
        _customer.PrintName();
        _customer.ConveyAddress();
    }
}