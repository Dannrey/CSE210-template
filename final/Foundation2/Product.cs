using System.Collections.Generic;
public class Product{
    // Attributes:
    private string _productName;
    private string _productID;
    private float _productPrice;
    private int _productQuantity;
    private Dictionary<string,float> _priceDictionary = new Dictionary<string,float>();  // For this and the next dictionary, I'll need to create methods that will generate this and the next dictionary.
    private Dictionary<string,string> _productDictionary = new Dictionary<string,string>();

    // Constructors:
    // public Product(){
    //     GetProductID();
    // }
    public Product(string ProductKey){
        Random random = new Random();
        _productID = ProductKey;
        CreatePriceDictionary();
        CreateProductDictionary();
        _productName = _productDictionary[_productID];
        _productPrice = _priceDictionary[_productID];
        _productQuantity = random.Next(1,5);
    }


    // Methods:
    public void CreatePriceDictionary(){
        _priceDictionary.Add("A110",1776);
        _priceDictionary.Add("A111",14);
        _priceDictionary.Add("A112",699);
        _priceDictionary.Add("A113",950);
        _priceDictionary.Add("A114",100);
        _priceDictionary.Add("A115",7000);
        _priceDictionary.Add("A116",120);
        _priceDictionary.Add("A117",1);
        _priceDictionary.Add("A118",73);
        _priceDictionary.Add("A119",78);
        // _priceDictionary.Add("A120",1);
    }
    public void CreateProductDictionary(){
        _productDictionary.Add("A110","Dell Latitude 360 Laptop");
        _productDictionary.Add("A111","Headphones");
        _productDictionary.Add("A112","iPhone SE 3rd edition");
        _productDictionary.Add("A113","Universal Self-Destruct Button");
        _productDictionary.Add("A114","The Complete D&D Starter Set");
        _productDictionary.Add("A115","Authentic Pirate Ship (crew not included)");
        _productDictionary.Add("A116","Nachos");
        _productDictionary.Add("A117","Air (1 gallon)");
        _productDictionary.Add("A118","Nitroglycerin (3 pints)");
        _productDictionary.Add("A119","Three Musketeers Full-Sized Candy Bar");
        // _productDictionary.Add("A120","");
    }

    public void GetProductID(){
        string ID;
        do {
            Console.Write("Please enter the product ID: ");
            ID = Console.ReadLine();
            if (_productDictionary.ContainsKey(ID) == true){
                _productID = ID;
            }
            else{
                Console.WriteLine("That is not a valid product ID.");
            }
        } while (_productDictionary.ContainsKey(ID) != true);
        
        // else{
        //     Console.WriteLine("That is not a valid product ID.");
        // }
    }
    public void GetProductQuantity(){
        Console.Write("Please enter a numeric quantity for how many of the item that was purchased: ");
        _productQuantity = int.Parse(Console.ReadLine());
    }
    public float GetPriceOfProduct(){
        return _productQuantity * _productPrice;
    }
    public void PrintPackingLabelInformation(){
        Console.WriteLine($"Product ID: {_productID}");
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"Product Price: ${_productPrice}");
        Console.WriteLine($"Quantity Purchased: {_productQuantity}");
    }
}