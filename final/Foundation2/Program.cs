using System;

class Program{
    static void Main(string[] args){
        // Console.WriteLine("Hello Foundation2 World!");
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
        Console.WriteLine();
        Console.WriteLine("Hit the enter key when you are ready to continue:");
        Console.ReadLine();

        foreach (Order _order in Orders){
            Console.Clear();
            Console.WriteLine();
            _order.PrintPackingLabel();
            Console.WriteLine();
            _order.PrintShippingLabel();
            Console.WriteLine();
            Console.WriteLine("Hit the enter key when you are ready to view the next order:");
            Console.ReadLine();
            Console.Clear();
        }
    }
}