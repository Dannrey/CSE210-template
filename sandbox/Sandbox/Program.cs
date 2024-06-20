using System;
using System.IO;
using System.Collections.Generic;


/* Here I am testing the sample code provided in the lesson instructions. 
What I am trying to figure out is how to actually call work with abstract methods.
I think I get it now.*/
class Program{
    static void Main(string[] args){
        // Create a list of Employees
        List<Employee> employees = new List<Employee>();
        // Create different kinds of employees and add them to the same list
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());
        // Get a custom calculation for each one
        foreach(Employee employee in employees){
            employee.SetSalary();
            float pay = employee.CalculatePay();
            Console.WriteLine(pay);
        }
    }
}
// class Program{
    // static void Main(string[] args){
        // Console.WriteLine(Math.PI);
    // }
// }