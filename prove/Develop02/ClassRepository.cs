using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/* So, here is where I defined my custom classes and functions.
It was necessary to do this in order to allow me to program with my easily reusable functions,
And I wanted to try something different with the format of my files. After all, in C languages, you don't
actually need to indent lines in order for the code to work. I'm using the indentations to help keep track of
what does what.*/
public class FileEditor {
    // First, I'll define variables that the function will use:
    public string _fileName;  // This contains the name of the file
    public string _addDate;   // This variable is meant to hold the date in a string
    public string _addTime;   // This variable holds the time in a string
    public string _addEntryPrompt;   // This variable holds the propmt that was given to the user
    public string _addEntryContent;   // This varible holds the content of the journal entry
    public List<string> _saveThis;   // This variable makes sure that previous entries do not get deleted.
    // Until I can figure out why this happens otherwise, I'll be using this.
    public FileEditor()
    {
    }
    
    public void ReadJournalEntries() {
        // Name: ReadJournalEntries
        // Purpose: Read text from a designated file
        // Parameters: None
        // Returns: None

        string[] lines = System.IO.File.ReadAllLines(_fileName);
    
        List<string> LineList = new List<string>();
        
        List<string> KeepThis = new List<string>();
        foreach (string line in lines) {
            string[] parts = line.Split("∞");
            foreach (string part in parts) {
                KeepThis.Add(part);
            }
            // LineList.Add(parts);
            // LineList.Add(line);
        }

        foreach (string i in KeepThis) {
            if (i != "∫") {
                Console.WriteLine(i);
            }
        }
        // return KeepThis;
    }

    public List<string> KeepJournalEntries() {
        /*
        Name: KeepJounrnalEntries
        Variables: None
        Returns: keepThis, a string list.
        */
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        List<string> LineList = new List<string>();

        
        List<string> KeepThis = new List<string>();
        foreach (string line in lines) {
            string[] parts = line.Split("∞");
            foreach (string part in parts) {
                KeepThis.Add(part);
            }
        }

        // foreach (string i in KeepThis) {
            // Console.WriteLine(i);
        // }
        return KeepThis;
    }

    public void AppendThis() {
        using (StreamWriter OutputFile = new StreamWriter(_fileName)) {
            int iteration = 0;
            foreach (string item in _saveThis) {
                OutputFile.WriteLine(_saveThis[iteration].Trim());
                iteration += 1;
            }
            OutputFile.WriteLine("\n"+_addDate.Trim());
            OutputFile.WriteLine(_addTime.Trim());
            OutputFile.WriteLine(_addEntryPrompt.Trim());
            OutputFile.WriteLine(_addEntryContent.Trim());
            OutputFile.Write("∞".Trim());
        }
    }
}

public class Entry {
    // This class will contain a selection of functions designed to be used on a key number being entered into
    // the corresponding question in the main program.
    
    // I also have a few variables that need to be created in order for this part of the program to work.
    // These are defined below:
    public string _entryContent;
    public string _dateString;
    public string _timeString;
    public string _prompt;

    public Entry()
    {
    }

    public string ObtainInformation() {
        // The ObtainInformation() function will take input from the user and store it inside a variable, ready to be appended to the
        // text file.
        string EntryData = "";
        string UserResponse = "";
        string AddThis = "";
        Console.WriteLine("Hit enter when you are ready to move onto a new line. Type 'QUIT()' to end this part of the program.");
        while (UserResponse != "QUIT()") {       // This while loop and following if statement are part of my creativity. This basically allows the user to format
            Console.Write("");                   // their entry, to an extent, by allowing you to enter a new line in. To exit, you type QUIT() in all caps and with
            UserResponse = Console.ReadLine();   // parenthesis. This function will store letters and the new lines.
            if (UserResponse != "QUIT()") {
                AddThis = EntryData;
                EntryData = $"{AddThis}\n{UserResponse}";
            }            
        }
        EntryData = $"{_timeString}\n{_dateString}\n{EntryData}";

        return EntryData;
    }

    public void DisplayInformation() {
        // DisplayInformation will display what was last written by the user.
        Console.WriteLine(_entryContent);
        Console.Write("Hit the enter key when you are ready to continue: ");
        Console.ReadLine();
    }
}

public class RandomizedPrompt {
    /* This class will only have a member variable and a function.
    Its purpose is to create and return a randomized variable each time it is called. 
    */

    public List<string> _randomizedPromptList;
    public string _randomizedPrompt;

    public RandomizedPrompt() 
    {
    }


    // Hey, here's a fun idea; what if I made it so that the user can enter custom prompts? That would require the use of anoher text file specifically with that.
    public List<string> GenerateRandomizedPrompt() {
        List<string> RandomList = new List<string>();
        RandomList.Add("What was the most exciting thing you did today?");
        RandomList.Add("What was the worst thing that happened to you today?");
        RandomList.Add("What was the best thing that you ate today?");
        RandomList.Add("Where did you go today?");
        RandomList.Add("What did you do in your offtime today?");
        RandomList.Add("What was the nicest thing you did for another today?");
        RandomList.Add("What was the nicest thing another did for you today?");
        RandomList.Add("What do you have to look forward to tomorrow?");
        RandomList.Add("What was the funniest thing you saw today?");
        RandomList.Add("Did you meet someone new today?");
        return RandomList;
    }
    
    public string SelectRandomizedPrompt() {
        Random randomGenerator = new Random();
        int RandomizedPlaceSelection = randomGenerator.Next(0,_randomizedPromptList.Count);
        string RandomizedSelection = _randomizedPromptList[RandomizedPlaceSelection];
        return RandomizedSelection;
    }

}
