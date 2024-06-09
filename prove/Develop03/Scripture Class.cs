using System.Diagnostics.CodeAnalysis;

public class Scripture {
    // Attributes:
    private string _scripture;
    private List<string> _modifiedScriptureText = new List<string>();
    private List<string> _wordsOfTheLivingProphets = new List<string>();


    // Constructors:
    public Scripture(string ChosenScripture){
        _scripture = ChosenScripture;
    }

    // methods:
    public void StringToWords() {
        List<string> parts = new List<string>();
        foreach (string i in _scripture.Split(" ")) {
            _wordsOfTheLivingProphets.Add(i);
        }
    }

    public string ExportWord() {
        int length = _modifiedScriptureText.Count();
        Random random = new Random();
        int Index = random.Next(0,length-1);
        string Export = _modifiedScriptureText[Index];
        
        List<string> letters = new List<string>();
        foreach (string i in Export.Split()) {
            letters.Add(i);
        }
        while (letters[0] == "_") {
            Index = random.Next(0,length-1);
            Export = _modifiedScriptureText[Index];
            int iteration = 0;
            foreach (string i in Export.Split()) {
                letters[iteration] = i;
                iteration += 1;
            }
        }
        return Export;
    }

    public void ReplaceSelectedWord(int position, string word) {
        // Alright. This will take one random word to replace and actually replace it in the second list.

    }

    public void StockScripture() {
        // _scripture.Split();
        foreach (string word in _scripture.Split(" ")) {
            _wordsOfTheLivingProphets.Add(word);
        }
        _modifiedScriptureText = _wordsOfTheLivingProphets;
    }

    public void RevealScripture() {
        foreach (string k in _wordsOfTheLivingProphets) {
            Console.Write(k);
            Console.Write(" ");
        }
        Console.Write("\n\nHit the enter key when you are ready to continue");
        Console.ReadLine();
    }
    public void DisplayScripture() {
        foreach (string j in _modifiedScriptureText) {
            Console.Write(j);
            Console.Write(" ");
        }
        // Console.Write("Do you want to reveal see the scripture (YES/NO)?");
        // string response = Console.ReadLine();
        // if (response.ToUpper() == "YES") {
        //     foreach (string k in _wordsOfTheLivingProphets) {
        //         Console.Write(k);
        //         Console.Write(" ");
        //     }
        // }
        Console.WriteLine();
        Console.Write("Hit the enter key when you are ready to continue:\n");
        Console.ReadLine();
        Console.Clear();
    }
}