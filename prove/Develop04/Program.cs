/*
File name: Program.cs
Author: Danniel Reynolds
Date: 06/10/2024 - 06/15/2024
Purpose: Initiate the wellness program and its activities.
*/


/* Creativity:
So, I have several features about this program that I am really proud of.
First of all, I love how I organized it. I had the idea for the layout as soon as I started talking with my team last
week to plan the program. It is unlike anything else I've ever made before and I plan to make future progams like 
this if possible.

As you will notice below, there is only one line of code inside my main program. This is because I have everything
else crucial for the program to run already defined inside the Activity class and its 3 child classes.
This is my first noteable part of the creativity portion of the assigment and also part of a challenge that I 
gave myself.

Secondly, inside the activity class, I have many different bits of reusable program. There was some modifications 
from what I originally said I was going to do inside my class diagram, but it generally kept to the same layout.
Almost everything that can be printed to the screen I have stored inside of a variable which is to be specifically 
called inside of the respective method, such as DisplayIntro() or DisplayInstructions(). For DisplayOutro(), I had
to do something a little bit different. While making the program, I had discovered that you cannot make an attribute
a formatted string, so for each outro message, aside from the main program's outro, I had it split in half and I have
it with a conditionaly so that if the message is from one of the three activities, it will place the duration in the
middle of the two halves, and for the main program itself it will only show the outro message.

Third, inside the BreathingActivity class, I made a special breathing guide. I had so much fun making that, and I actually
had two versions of it. The one that made it into the program is designed to finish each breathe and to not leave the
user holding their breath, pun intended. The original version of this enhanced breather guide message is in the sandbox
file and will cut the current breath short.

Fourth, I wouldn't classify this as a point of creativity, but I made two constructors for the Activity class, whereas
each of the child classes have only one constructor. This is because the first constructor, the one that takes a string
value, acts to run the program, whereas the second one was constructed to do nothing other than initialize the class
and to make sure that each of the subclasses' constructors worked properly without accidentally setting off a second
stem of the program.

Lastly, I also made use of the Console.Beep() command for the breathing and listing activity and in the listing 
activity I have it so that the program will return a message based on how many responses it gets from the user. There
might be other things that I added as well, but I can't remember them.

I really enjoyed making this program, I hope you enjoy it!
*/ 
using System;

class Program{
    static void Main(string[] args){
        Activity activity = new Activity("");
    }
}