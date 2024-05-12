using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// So, here is where I defined my custom classes and functions.
// It was necessary to do this in order to allow me to program with my easily reusable functions,
// And I wanted to try something different with the format of my files. After all, in C languages, you don't
// actually need to indent lines in order for the code to work. I'm using the indentations to help keep track of
// what does what.
public class FileEditor {
    // First, I'll define variables that the function will use:
    public string _fileName;  // This contains the name of the file
    public string _addDate;   // This variable is meant to hold the date in a string
    public string _addTime;   // This variable holds the time in a string
    public string _addEntryPrompt;   // This variable holds the propmt that was given to the user
    public string _addEntryContent;   // This varible holds the content of the journal entry
    public List<string> _saveThis;   // This is vital for the program to actually keep the previous journal entries.
    // I don't know why, but my first attempts always deleted what was already inside the text file, so I added this
    // to maintain what was already there. It might take up a lot of temporary computer storage space but it was the
    // only and fastest way that I could concieve to fix the problem.

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
            string[] parts = line.Split("∫");
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


    public void AppendThis(List<string> ListX) {
        using (StreamWriter OutputFile = new StreamWriter(_fileName)) {
            int iteration = 0;
            foreach (string item in ListX) {
                OutputFile.WriteLine(ListX[iteration]);
                iteration += 1;
            }
        
            // OutputFile.WriteLine("∫");
            OutputFile.WriteLine("\n"+_addDate.Trim());
            OutputFile.WriteLine(_addTime.Trim());
            OutputFile.WriteLine(_addEntryPrompt.Trim());
            OutputFile.WriteLine(_addEntryContent.Trim());
            OutputFile.WriteLine("∫".Trim());
        }
    }
    
}

public class UserSelection {
    // This class will contain a selection of functions designed to be used on a key number being entered into
    // the corresponding question in the main program.
    
    // I also have a few variables that need to be created in order for this part of the program to work.
    // These are defined below:
    public string _rememberThis;


    public UserSelection()
    {
    }

    public string Selection1() {
        // Selection1 will take input from the user and store it inside a variable, ready to be appended to the
        // text file.
        string RecorderEso = "";
        string UserResponse = "";
        string TheThirdOne = "";
        Console.WriteLine("Hit enter when you are ready to move onto a new line. Type 'QUIT()' to end this part of the program.");
        while (UserResponse != "QUIT()") {
            Console.Write("");
            if (UserResponse != "QUIT()") {
                UserResponse = Console.ReadLine();
                TheThirdOne = RecorderEso;
                RecorderEso = $"{TheThirdOne}\n{UserResponse}";
            }
            else {
                string EmptyVariable = Console.ReadLine();
            }
            
        }
        return RecorderEso;
    }

    public void Selection2() {
        // Selection2 will display what was last written by the user.
        Console.WriteLine(_rememberThis);
        Console.Write("Hit the enter key when you are ready to continue: ");
        string EmptyVariable = Console.ReadLine();
    }


}