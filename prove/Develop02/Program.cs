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
DisplayThese Journal = new DisplayThese();
Journal._fileName = MyDoc;
Journal._addDate = theCurrentTime.ToShortDateString();
Journal._addTime = theCurrentTime.ToShortTimeString();

// Console.Write("What do you wish to enter? ");
// Journal._addEntryContent = Console.ReadLine();

// Console.WriteLine("Make up a prompt: ");
// Journal._addEntryPrompt = Console.ReadLine();

Journal._saveThis = Journal.KeepJournalEntries();
// Journal.ReadJournalEntries();
// Journal.AppendThis();


// UserSelection class refenrences:
UserSelection Choice = new UserSelection();
Choice._rememberThis = "You have not entered anything yet";

// Now that I have the code backbone set up, I can go build the part of the program that the user would actually
// interact with:
Console.WriteLine("Hello and welcome! I am the Journal Application and Reminder Establishment Device, but you may call me\nJ.A.R.E.D.");
Console.WriteLine("My purpose today is to provide you with a prompt to assist you in keeping a consistent journal.");
Console.WriteLine("Each of the selection options will have their own individual instruction that will be displayed when you select one,\n");
Console.WriteLine("and you can select all options multiple times (aside from option 5, since that closes the program).");
Console.WriteLine("My methods to assist you today are:");
// Console.Write("Please select and type a numeric option from the list: ");
// string UserInput = Console.ReadLine();


string UserInput;
do {
    Console.WriteLine("\t1. Write a new entry\n\t2. Display current entry\n\t3. Load previous entries\n\t4. Save entry\n\t5. Quit\n");
    Console.Write("Please select and type a numeric option from the list: ");
    UserInput = Console.ReadLine();
    if (UserInput == "1") {
        Choice._rememberThis = Choice.Selection1();
    }
    else if (UserInput == "2") {
        Choice.Selection2();
    }
} while (UserInput != "5");

}
}