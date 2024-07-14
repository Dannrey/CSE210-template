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
    public Product(){

    }


    // Methods:
    public void CreatePriceDictionary(){
        _priceDictionary.Add("A110",1776+50/100);
        _priceDictionary.Add("A111",14+50/100);
        _priceDictionary.Add("A112",699+99/100);
        _priceDictionary.Add("A113",950+12/100);
        _priceDictionary.Add("A114",100);
        _priceDictionary.Add("A115",436+75/100);
        _priceDictionary.Add("A116",12+15/100);
        _priceDictionary.Add("A117",0+12/100);
        _priceDictionary.Add("A118",70+3/100);
        _priceDictionary.Add("A119",78/100);
        // _priceDictionary.Add("A120",1);
    }
    public void CreateProductDictionary(){
        _productDictionary.Add("A110","Dell Latitude 360 Laptop");
        _productDictionary.Add("A111","Headphones");
        _productDictionary.Add("A112","iPhone SE 3rd edition");
        _productDictionary.Add("A113","Universal Self-Destruct Button");
        _productDictionary.Add("A114","The Complete D&D Starter Set");
        _productDictionary.Add("A115","");
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


}  // Okay. I stand corrected. I'll make two dictionaries that will use the product ID as a keyword, and each of the two dictionaries will hold information pertaining to the price of the object and its name.