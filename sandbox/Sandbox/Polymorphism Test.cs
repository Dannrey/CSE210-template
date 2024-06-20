// the parent class showing the "virtual" keyword included
public class Employee{
    private float _salary = 100f;


    // public Employee(){
    // }
    // public Employee(string placeholder){
        // SetSalary();
        // CalculatePay();
    // }


    public virtual void SetSalary(){
        Console.Write("What is the salary? ");
        _salary = float.Parse(Console.ReadLine());
    }
    public virtual float CalculatePay(){
        return _salary;
    }
}

// a child class
public class HourlyEmployee : Employee{
    private float _rate = 9f;
    private float _hours = 100f;


    // public HourlyEmployee(){
    // }
    // public HourlyEmployee(string placeholder){ //: base(""){
        // SetSalary();
        // CalculatePay();
    // }

    public override void SetSalary(){
        Console.Write("What is the rate? ");
        _rate = float.Parse(Console.ReadLine());

        Console.Write("How long has the employee worked? ");
        _hours = float.Parse(Console.ReadLine());
    }
    public override float CalculatePay(){
        return _rate * _hours; // pay is calculated differently
    }
}