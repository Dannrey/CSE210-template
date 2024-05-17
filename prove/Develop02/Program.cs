/*
File name: Program.cs
Author: Danniel Reynolds
Date: 5/11/2024 - 5/??/2024
Purpose: 
*/

/*
So, in this file I have several features added for the craetiviy portion of the assignment. 
First and formost, I gave the program a name to call itself. That alone I would not classify
for the entire portion of the creativity of the assignment, but I added more.
I also made the program so that it will generate a new prompt each time the user selects option 1, Write a new entry,
Option 1 also presents the user with the option to put new lines inside the middle of their entry rather than 
just making one long, continuous string. This is a neat feature, I think. After that, I also designed the 
program to keep track of the time that an entry was written, and my thought was because someone might come back 
later in the same day and add another entry.
After that, I also provied some formatting for when the file itself is ran, such as while the program is saving,
I added some code to cause the display to take a little time to generate a response when you select option 3, save entry.
I learned this bit of code from one of my team members, Jeremy Untch.
I also used the .Trim() method in the second option, Display current entry. I went online and learned the .Trim() method from: learn.microsoft.com
I also did something similar in the fourth option that the user can select, which is the Save entry option.
I also added some code to handle any input that does not relate to one of the selections. This alerts the user to
the fact that they did not actually enter a valid option.
Lastly, 
*/

using System;
using System.IO;
using System.Collections.Generic;

// Okay, here is the Program class. This will be where the magic happens inside this file.
class Program {
    static void Main(string[] args) {
        // Global Variables:
        string MyDoc = "MyTextFile.txt";

        // FileEditor class references:
        FileEditor Journal = new FileEditor();
        Journal._fileName = MyDoc;
        Journal._addDate = "";
        Journal._addTime = "";
        Journal._saveThis = Journal.KeepJournalEntries();

        DateTime theCurrentTime = DateTime.Now;
        // Entry Class references:
        Entry entry = new Entry();
        entry._entryContent = "You have not entered anything yet!"; 
        entry._dateString = theCurrentTime.ToShortDateString();
        entry._timeString = theCurrentTime.ToShortTimeString();
        entry._prompt = "emptry prompt";


        // RandomizedPrompt Class references:
        RandomizedPrompt Prompt = new RandomizedPrompt();
        Prompt._randomizedPromptList = Prompt.GenerateRandomizedPrompt();

        // I always include something like this when I create a larger program for my class.
        Console.WriteLine("Hello and welcome! I am the Journal Application and Reminder Establishment Device, but you may call me\nJ.A.R.E.D.");
        Console.WriteLine("My purpose today is to provide you with a prompt to assist you in keeping a consistent journal and to save any\nentry that you might make.");
        Console.WriteLine("Each of the selection options will have their own individual instruction that will be displayed when you select one,\n");
        Console.WriteLine("and you can select all options multiple times (aside from option 5, since that closes the program).");
        Console.WriteLine("My methods to assist you today are:\n");

        string UserInput;
        do {
            Console.WriteLine("\t1. Write a new entry\n\t2. Display current entry\n\t3. Load previous entries\n\t4. Save entry\n\t5. Quit\n");
            Console.Write("Please select and type a numeric option from the list: ");
            UserInput = Console.ReadLine();
            if (UserInput == "1") {
                Console.WriteLine("This option will allow you to create a new entry.");
                Console.WriteLine("Before you can enter your entry, I need to provide you with a randomly selected prompt.");
                Console.WriteLine("Again, it is up to you whether or not to head the prompt, but nevertheless, here it is:");

                Prompt._randomizedPrompt = Prompt.SelectRandomizedPrompt();
                Journal._addEntryPrompt = Prompt._randomizedPrompt;
                entry._prompt = Journal._addEntryPrompt;
                Console.WriteLine(Prompt._randomizedPrompt);

                entry._dateString = theCurrentTime.ToShortDateString();
                entry._timeString = theCurrentTime.ToShortTimeString();

                entry._entryContent = entry.ObtainInformation();
                Journal._addEntryContent = entry._entryContent;
                Console.WriteLine();
            }
            else if (UserInput == "2") {
                if (Journal._addEntryContent.Trim() == "") {
                    Console.WriteLine("I'm sorry, but you didn't actually type anything.");
                }
                else {
                    entry.DisplayInformation();
                }
                Console.WriteLine();

            }
            else if (UserInput == "3") {
                Journal.ReadJournalEntries();
            }

            else if (UserInput == "4") {
                if (Journal._addEntryContent == "You have not entered anything yet!"||Journal._addEntryContent.Trim() =="") {
                    Console.WriteLine("You have not entered anything yet! Please type something");
                }
                else {
                    Journal._saveThis = Journal.KeepJournalEntries();
                    Journal._addEntryContent = entry._entryContent;
                    Journal.AppendThis();
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine("."); 
                    Thread.Sleep(1000);
                    Console.Write("Saving");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.WriteLine("Save Complete, hit Enter when you are ready to continue.");
                    Console.ReadLine();
                }
            }
            else if (UserInput == "5") {
                Console.WriteLine("See you soon!");
            }
            else {
                // I wasn't told to put this into the program specifically, but I like to have something in the event that the user entered something that was not part of the selection list.
                Console.WriteLine("Sorry, but that is not one of the available options. Please try again.");
            }
            Console.WriteLine();
        } while (UserInput != "5");

    }
}