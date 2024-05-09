using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}


// My experiment with classes.
// So, I actually managed to figure it out, and I'm glad about it.

// public class Person
// {
//     public string _givenName = "";
//     public string _familyName = "";

//     public Person()
//     {
//     }

//     public void ShowEasternName()
//     {
//         Console.WriteLine($"{_familyName}, {_givenName}");
//     }

//     public void ShowWesternName()
//     {
//         Console.WriteLine($"{_givenName} {_familyName}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person();
//         person._givenName = "Danniel";
//         person._familyName = "Reynolds";
//         person.ShowWesternName();
//         person.ShowEasternName();

//         Console.WriteLine();

//         Person person2 = new Person();
//         person2._givenName = "Teddy";
//         person2._familyName = "Roosevelt";
//         person2.ShowWesternName();
//         person2.ShowEasternName();
//     }
// }

// So, as it turns out, you need to define custom classes outside of the thing designated "class program".
// Aside from that, I do believe that I figured it out.