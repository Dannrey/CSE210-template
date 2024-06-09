// Alright. I've already created the rough outline, so all that is left to do is create the class and its methods:

using System.Globalization;

public class GospelLibrary {
    // Attributes (they should all be private):
    private Dictionary<string,string> _bibleDictionary = new Dictionary<string,string>();
    private string _selectedScripture;
    private List<string> _referenceLibrary = new List<string>();
    private int _selectedKeyIndex;
    private string _scriptureReference;

    // Constructors:
    public GospelLibrary(string Decision) {
        Console.Clear();
        if (Decision.ToUpper() == "RANDOM") {
            StockBibleDictionary();
            RandomScriptureSelector();
        }
        else {
            StockBibleDictionary();
            Console.WriteLine("Which of the following scriptures do you want study? ");
            foreach (string scripture in _referenceLibrary) {
                Console.WriteLine(scripture);
            }
            Console.Write("");
            _scriptureReference = Console.ReadLine();
            bool trial = false;
            while (trial != true) {
                if (_referenceLibrary.Contains(_scriptureReference) == true) {
                    _selectedScripture = _bibleDictionary[_scriptureReference];
                    trial = true;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Sorry, but that reference is invalid.");
                    Console.WriteLine("Try typing the reference as it is displayed.");
                    // Console.WriteLine("Hit the enter key when you are ready to continue: ");
                    Console.Read();
                    Console.Clear();

                    Console.WriteLine("Which of the following scriptures do you want study? ");
                    foreach (string scripture in _referenceLibrary) {
                        Console.WriteLine(scripture);
                    }
                    Console.Write("");
                    _scriptureReference = Console.ReadLine();
                }
            } //while (trial != true);
        }
    }


    // Methods:
    public void StockBibleDictionary() {
        _bibleDictionary.Add("Matthew 5:14-16","Ye are the light of the world. A city that is set on an hill cannot be hid.\nNeither do men light a candle, and put it under a bushel, but on a candle-stick; and it giveth light unto all that are in the house.\nLet your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        _bibleDictionary.Add("John 3:5","Jesus answered, Verily, verily, I say unto thee,\nExcept a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        _bibleDictionary.Add("James 1:5-6","If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.\nBut let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        _referenceLibrary.Add("Matthew 5:14-16");
        _referenceLibrary.Add("John 3:5");
        _referenceLibrary.Add("James 1:5-6");
    }
    public void RandomScriptureSelector() {
        Random random = new Random();
        _selectedKeyIndex = random.Next(0,_referenceLibrary.Count-1);

        _scriptureReference = _referenceLibrary[_selectedKeyIndex];
        _selectedScripture = _bibleDictionary[_referenceLibrary[_selectedKeyIndex]];
        // Console.WriteLine(_selectedScripture);
    }
    public string GetReference() {
        return _scriptureReference;
    }
    public string GetScripture() {
        return _selectedScripture;
    }

    // private _
}