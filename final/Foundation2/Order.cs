public class Order{
    // Attributes:
    private List<Product> _products = new List<Product>();
    // private Address _address = new Address();
    private Customer _customer = new Customer();
    private List<string> _productKeys = new List<string>(["A110","A111","A112","A113","A114","A115","A116","A117","A118","A119",]);

    // Constructors:
    public Order(){
        // GenerateProductList();
        ObtainProductList();
        // _customer.SetAddressInformation()
    }



    // Methods:
    public void ObtainProductList(){
        Console.WriteLine("I will display to you a list of items with their associate product key.\nI will then ask you a series of questions to acquire what items are purchased and how many of each.");
        Product product = new Product("A113",12);
        // _products[0].DisplayProductDictionary();
        product.DisplayProductDictionary();
        Console.WriteLine();
        Console.Write("How many items are on your list? ");
        int ShoppingListLength = int.Parse(Console.ReadLine());
        int iteration = 0;
        while (iteration < ShoppingListLength){
            Console.Clear();
            product.DisplayProductDictionary();
            Console.WriteLine();
            Console.Write("Please enter an item key from the list of products: ");
            string ItemKey = Console.ReadLine();
            Console.Write("How much of the product was purchased? ");
            int QuantityPurchased = int.Parse(Console.ReadLine());
            Product NewProduct = new Product(ItemKey,QuantityPurchased);
            _products.Add(NewProduct);
            iteration += 1;
        }
        
    }
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
        Console.WriteLine("Puchases (Packing information):\n");
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