public class Reference {

    // Attributes:
    private string _scriptureReference;
    private string _hiddenReference;
    // private bool _hideReference;


    // Constructors:
    public Reference(string reference) {
        _scriptureReference = reference;
        _hiddenReference = _scriptureReference;
    }


    // Methods:

    // public void GetReferenceStatus() {
    //     if (_hideReference != true) {
    //         Random random = new Random();
    //         int Max = 3;
    //         int Determiner = random.Next(0,Max);
    //         if (Determiner == Max) {
    //             _hideReference = true;
    //         }
    //         else {
    //             _hideReference = false;
    //         }
    //     }
    // }
    // public void SetReferenceStatus() {
    //     _hideReference = true;
    // }

    public void DisplayReference() {
        Console.WriteLine(_hiddenReference);
        // if (_hideReference == true) {
            // Console.Write("Display Reference (yes/no)? ");
            // string Show = Console.ReadLine();
            // if (Show.ToLower() == "yes") {
            //     Console.WriteLine(_scriptureReference);
            // }
        // }
    }

    public void RevealHiddenReference() {
        Console.WriteLine(_scriptureReference);
    }

    public void HideCharacters() {
        // // if (_hideReference == true) {
        // List<string> parts = new List<string>();
        // foreach (string part in _scriptureReference.Split("")) {
        //     if (char.IsLetter(part,0)) {
        //         parts.Add("_");
            
        //     else if (char.IsNumber(part,0)) {
        //         parts.Add("_");
        //     }
        //     else {
        //         parts.Add(part);
        //     }
            // parts.Add(part);
        // }
        // int iteration = 0;
        string Characters = "";
        // _hiddenReference = "";
        string x = "";
        foreach (string i in _scriptureReference.Split("")) {
            if (char.IsLetter(i,0)) {
                x = "_";
            }
            else if (char.IsNumber(i,0)) {
                x = "_";
            }
            else {
                x = i;
                
            }

            string letters = $"{Characters}{x}";
            Characters = letters;
        
            _hiddenReference = Characters;
            // foreach (string j in parts) {
                // _hiddenReference = $"{Characters}{j}";
            // }
        }
    }

        
}
// }