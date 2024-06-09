/*
File namme: Program.cs
Author: Danniel Reynolds
Date:05/27/2024 - 06/01/2024
Purpose: Demonstrate mastery over the principle of encapsulation.
*/

using System;
using System.Collections.Generic;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        // First things first, introduce the program and explain initial instructions:
        Console.WriteLine("Hello, and welcome. I am your Scripture Assistant for Memorization, but you may call me S.A.M.");
        Console.WriteLine("My purpose today is to help you memorizing scriptures. I can either randomly select one or you can type\nin a reference and I will dsiplay that reference for you.");
        Console.WriteLine("After a scripture is selected, it will be displayed. The first time it is displayed, you will see the whole\nscripture");
        Console.WriteLine("Every time after that it is first displayed, one randomly selected word will be removed, but upon your command,");
        Console.WriteLine("the entire scripture passage will be shown.");
        Console.WriteLine("Whenever there is a choice for you to make, it will shown in all capitalized letters.");

        Console.Write("Hit the enter key to continue");
        Console.ReadLine();        

        string Selection;
        do {
            Console.Write("Do you want to try mastering a RANDOM scripture or do you want to SELECT one? ");
            Selection = Console.ReadLine();
            if (Selection.ToUpper() == "RANDOM") {
                // GospelLibrary MasteryScripture = new GospelLibrary(Selection);
            }
            else if (Selection.ToUpper() == "SELECT") {
                // GospelLibrary MasteryScripture = new GospelLibrary(Selection);
            }
            else {
                Console.Write("I'm sorry, but that is not one of the options. Please try again (Hit the enter key to continue).");
                Console.ReadLine();
                // Console.Write("Do you want to try mastering a RANDOM scripture or do you want to SELECT one? ");
                Console.Clear();
            }
        } while (Selection.ToUpper() != "RANDOM" && Selection.ToUpper() != "SELECT");
        
        // So, my original idea was to have this inside of that do-while loop, but that didn't work. So, I worked something out where I had it here,
        // and now it only needs one constructor.
        GospelLibrary MasteryScripture = new GospelLibrary(Selection);
        
        // Alright. So now that I have that done, I need to take the scritpure out of the GospelLibrary:
        string TheScripture = MasteryScripture.GetScripture();

        // Now that that is done, I can pass it into the Scripture class:
        Scripture verses = new Scripture(TheScripture);
        
        // On a similar note, I need to put the reference into the reference class:
        string TheReference = MasteryScripture.GetReference();
        Reference reference = new Reference(TheReference);
        
        Console.WriteLine();
// 
        
        // Console.WriteLine();
        Console.Clear();
        Console.WriteLine("You selected scripture is:\n");
        reference.RevealHiddenReference();
        verses.StockScripture();
        verses.RevealScripture();
        // verses.ShowScripture();
        string UserSelection = "";
        bool ReferenceStatus = false;
        do {
            Console.WriteLine();
            if (ReferenceStatus == false) {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("REVIEW scripture\nCONTINUE\nHIDE reference\nEXIT program");
                Console.Write("What will it be? ");
                UserSelection = Console.ReadLine();
            }
            else {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("REVIEW scripture\nCONTINUE\nEXIT program");
                Console.Write("What will it be? ");
                UserSelection = Console.ReadLine();
            }
            Console.WriteLine();
            if (UserSelection.ToUpper() == "REVIEW") {
                reference.RevealHiddenReference();
                verses.RevealScripture();
            }
            else if (UserSelection.ToUpper() == "HIDE") {
                // reference.SetReferenceStatus();
                reference.HideCharacters();
                ReferenceStatus = true;
            }
            else if (UserSelection.ToUpper() == "CONTINUE") {
                reference.DisplayReference();
                verses.DisplayScripture();
            }
        } while (UserSelection.ToUpper() != "EXIT");

        // Now that I have that, I need to include some of the other functionalities.
        // To start with, I need to display what scripture was selected along with its reference:
        ;
    }
}