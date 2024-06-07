using System;
using System.IO;
using System.Collections.Generic;


// Okay. So, today I am testing out how to create a dictionary. In hindsight, I probably should have done this sooner, but hey, hindsight is 20: 20.
class Program {
    static void Main(string[] args) {
        Student student = new Student("Danniel","5969");
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);
    }
}

// Alright, I feel comfortable with constructing dictionaries now. Now to move on to the main project of week 6!