using System;

class Program{
    static void Main(string[] args){
        // For the purpose of this program, I will have three randomly determined announcements generated, one for each of the subclasses.
        Console.Clear();
        Console.WriteLine("This program helps create posters and notices for events.");
        Console.WriteLine("It will display three announcements.\nPlease follow the onscreen instructions.");
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();
        
        LectureEvent Lecture = new LectureEvent();
        OutDoorEvent OutDoor = new OutDoorEvent();
        ReceptionEvent Reception = new ReceptionEvent();
        
        Console.WriteLine("The first event is a lecture:\n");
        Console.WriteLine();
        Console.WriteLine("Full details:");
        
        Lecture.FullDetails();
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Standard Description:");
        Lecture.StandardDetails();
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Brief Description:");
        Lecture.BriefDescription();
        // Console.Write("Hit enter to quit the application:");
        Console.Write("Hit the enter key when you are ready to continue");
        Console.ReadLine();
        Console.Clear();


        // This is for the outdoor event:
        
        Console.WriteLine("The first event is a lecture:\n");
        Console.WriteLine();
        Console.WriteLine("Full details:");
        
        OutDoor.FullDetails();
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Standard Description:");
        OutDoor.StandardDetails();
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Brief Description:");
        OutDoor.BriefDescription();
        // Console.Write("Hit enter to quit the application:");
        Console.Write("Hit the enter key when you are ready to continue");
        Console.ReadLine();
        Console.Clear();



        // This is for the Reception event:
        Console.WriteLine("The first event is a lecture:\n");
        Console.WriteLine();
        Console.WriteLine("Full details:");
        
        Reception.FullDetails();
        Console.Write("Hit the enter key when you are ready to continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Standard Description:");
        Reception.StandardDetails();
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Brief Description:");
        Reception.BriefDescription();
        Console.Write("Hit enter to quit the application:");
        // Console.Write("Hit the enter key when you are ready to continue");
        Console.ReadLine();
        Console.Clear();

    }
}