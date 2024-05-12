using System;
using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello Sandbox World!");
//         public class Blinds;
//         {
//             public double height;
//             public double width;
//             public double color;
//         }
        
//     }
//     // Blinds kitchen = new Blinds();
// }


// My experiment with classes.
// So, I actually managed to figure it out, and I'm glad about it.
public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public Person()
    {
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        string time = theCurrentTime.ToShortTimeString();
        Console.WriteLine($"The current date is {date}, and the hour is {time}");
    }
}

// So, as it turns out, you need to define custom classes outside of the thing designated "class program".
// Aside from that, I do believe that I figured it out.