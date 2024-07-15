using System;

class Program{
    static void Main(string[] args){
        // Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Console.WriteLine("Hello, I am the Shipping Assistant and Manager, but you may call me S.A.M.");
        Console.WriteLine("My purpose today is to assist in organizing information from multiple costumers and\ndisplay that information along with their customer information.");
        Console.Write("Please follow the onscreen instructions.\n\nHit the enter key when you are ready to begin analyzing the customer information: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Preparing to display consumer information.");

        // Okay. So what I need to do is create a list of orders and print the information pertaining to it,
        Random random = new Random();
        int OrderCount = random.Next(3,5);
        int iteration = 0;
        List<Order> Orders = new List<Order>(); 
        while (iteration != OrderCount){
            Order order = new Order();
            Orders.Add(order);
            iteration += 1;
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine();
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();

        iteration = 0;
        foreach (Order _order in Orders){
            iteration += 1;
            Console.Clear();
            Console.WriteLine();
            _order.PrintPackingLabel();
            Console.WriteLine();
            _order.PrintShippingLabel();
            Console.WriteLine();
            if (iteration < Orders.Count){
                Console.Write("Hit the enter key when you are ready to view the next order: ");
                Console.ReadLine();
                Console.Clear();
            }
            else if (iteration == Orders.Count){
                Console.Write("Hit the enter key when you are ready to exit the application: ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}