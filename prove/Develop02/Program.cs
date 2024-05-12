using System;
using System.IO;
using System.Collections.Generic;

// Okay, here is the Program class. This will be where the magic happens inside this file.
class Program {
static void Main(string[] args) {
// Global Variables:
string MyDoc = "MyTextFile.txt";


// DateTime class reference:
DateTime theCurrentTime = DateTime.Now;


// DisplayThese class references:
FileEditor Journal = new FileEditor();
Journal._fileName = MyDoc;
Journal._addDate = theCurrentTime.ToShortDateString();
Journal._addTime = theCurrentTime.ToShortTimeString();

// This will be a combination of an instance of the random class and a reference to my DisplayThese class.
Random randomGenerator = new Random();
List<string> RandomList = new List<string>();
RandomList.Add("What was the most exciting thing you did today?");
RandomList.Add("What was the worst thing that happened to you today?");
RandomList.Add("What was the best thing that you ate today?");
RandomList.Add("Where did you go today?");
RandomList.Add("What did you do in your offtime today?");



Journal._saveThis = Journal.KeepJournalEntries();
// Journal.ReadJournalEntries();
// Journal.AppendThis();


// UserSelection class refenrences:
UserSelection Choice = new UserSelection();
Choice._rememberThis = "You have not entered anything yet!";

// Now that I have the code backbone set up, I can go build the part of the program that the user would actually
// interact with:
Console.WriteLine("Hello and welcome! I am the Journal Application and Reminder Establishment Device, but you may call me\nJ.A.R.E.D.");
Console.WriteLine("My purpose today is to provide you with a prompt to assist you in keeping a consistent journal and to save any\nentry that you might make.");
Console.WriteLine("Each of the selection options will have their own individual instruction that will be displayed when you select one,\n");
Console.WriteLine("and you can select all options multiple times (aside from option 5, since that closes the program).");
Console.WriteLine("My methods to assist you today are:\n");
// Console.Write("Please select and type a numeric option from the list: ");
// string UserInput = Console.ReadLine();


string UserInput;
do {
    Console.WriteLine("\t1. Write a new entry\n\t2. Display current entry\n\t3. Load previous entries\n\t4. Save entry\n\t5. Quit\n");
    Console.Write("Please select and type a numeric option from the list: ");
    UserInput = Console.ReadLine();
    if (UserInput == "1") {
        Console.WriteLine("This option will allow you to create a new entry.");
        Console.WriteLine("Before you can enter your entry, I need to provide you with a randomly selected prompt.");
        Console.WriteLine("Again, it is up to you whether or not to head the prompt, but nevertheless, here it is:");
        
        Journal._addDate = theCurrentTime.ToShortDateString();
        Journal._addTime = theCurrentTime.ToShortTimeString();

        int PlaceSelecter = randomGenerator.Next(0,RandomList.Count);
        Journal._addEntryPrompt = RandomList[PlaceSelecter];
        Console.WriteLine($"{Journal._addEntryPrompt}");

        string TransitoryVariable1 = Choice.Selection1();

        // Now, if you pay close attention you might be wondering what is going on here. Well, I'm glad you asked, or 
        // stopped to read this comment. I noticed that for some reason my code was including "QUIT()" at the end of each 
        // of my entries, and so, rather than going through and possibly messing up the code in an attempt to remove that,
        // I made a few lines here to pluck out the QUIT() option for me. It might seem like the long, roundabout way to 
        // accomplish this task but it seemed the simplest to me and I've done similar things to it before.
        // In the long run, it would be better to go back and modify the original function itself since that would root out
        // any future errors if I chose to reuse the code, butfor this single assignment it works perfectly well.
        List<string> TransitoryList = new List<string>();
        TransitoryList.Add(TransitoryVariable1);
        foreach (string item in TransitoryList) {
            string[] parts = item.Split("QUIT()");
            Choice._rememberThis = parts[0];
        }
        Journal._addEntryContent = Choice._rememberThis;
    }
    else if (UserInput == "2") {
        if (Journal._addEntryContent.Trim() == "") {
            Console.WriteLine("I'm sorry, but you didn't actually type anything.");
        }
        else {
            Choice.Selection2();
        }
        
    }
    else if (UserInput == "3") {
        Journal.ReadJournalEntries();
    }

    else if (UserInput == "4") {
        if (Journal._addEntryContent == "You have not entered anything yet"||Journal._addEntryContent.Trim() =="") {
            Console.WriteLine("You have not entered anything yet! Please type something");
        }
        else {
            Journal._saveThis = Journal.KeepJournalEntries();
            Journal._addEntryContent = Choice._rememberThis;
            Journal.AppendThis(Journal._saveThis);
            Console.WriteLine("...");
            Console.WriteLine("Saving...");
            Console.WriteLine("Save Complete, Hit enter when you are ready to continue.");
            Console.ReadLine();
            
        }
    }
    else if (UserInput == "5") {
        Console.WriteLine("See you soon!");
    }
    else {
        Console.WriteLine("Sorry, but that is not one of the available options. Please try again.");
    }
    Console.WriteLine();
} while (UserInput != "5");

}
}