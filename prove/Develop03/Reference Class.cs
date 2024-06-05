public class Reference {

    // Attributes:
    private string _scriptureReference;
    private string _hiddenReference;
    private bool _hideReference;


    // Constructors:
    public Reference(string reference) {
        _scriptureReference = reference;
        _hiddenReference = _scriptureReference;
    }


    // Methods:

    public void GetReferenceStatus() {
        if (_hideReference != true) {
            Random random = new Random();
            int Max = 3;
            int Determiner = random.Next(0,Max);
            if (Determiner == Max) {
                _hideReference = true;
            }
            else {
                _hideReference = false;
            }
        }
    }

    public void DisplayReference() {
        Console.WriteLine(_hiddenReference);
        if (_hideReference == true) {
            Console.Write("Display Reference (yes/no)? ");
            string Show = Console.ReadLine();
            if (Show.ToLower() == "yes") {
                Console.WriteLine(_scriptureReference);
            }
        }
    }

    public void HideCharacters() {
        if (_hideReference == true) {
            List<string> parts = new List<string>();
            foreach (string part in _scriptureReference.Split("")) {
                parts.Add(part);
            }
            int iteration = 0;
            string Characters = "";
            foreach (string i in parts) {
                if (i != ":" && i != " " && i != "-") {
                    parts[iteration] = "_";
                    iteration += 1;
                }
                else {
                    parts[iteration] = i;
                }
            }
            foreach (string j in parts) {
                _hiddenReference = $"{Characters}{j}";
            }
        }
    }
}