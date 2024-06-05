public class Word {
    // Attributes:
    // private bool _hiddenStatus;  // Well, I don't know if this one is really necessary since the Scripture class will randomly detemine if 
    private string _wordText;


    // Constructors:
    public Word(string word) {
        _wordText = word;
    }


    // Methods:
    private void ReplaceSelectedWord() {
        // So, this function will take the word, split it up, and replace any letter, and only letters. It will leave puctuation the same, but everything and anything else it will leave
        List<string> letters = new List<string>();
        foreach (string part in _wordText.Split()) {
            letters.Add(part);
        }
        int iteration = 0;
        foreach (string letter in letters) {
            bool ToF = Char.IsLetter(letter,0);
            if (Char.IsLetter(letter,0) == true) {
            // if (ToF == true) {
                letters[iteration] = "_";
            }
            // else if (Char.IsNumber(letter,0) == true || Char.IsPunctuation(letter,0) ){
            // }
            // }
            iteration += 1;
        }
        _wordText = "";
        foreach (string item in letters) {
            _wordText = $"{_wordText}{item}";
        }
    }
    
    public string ReturnHiddenWord() {
        return _wordText;
    }
}