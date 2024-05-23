public class Fraction {
    // Define member varibles:
    private double _numerator;
    private double _denominator;
    private double _fractionValue;
    private string _fractionString;
    public Fraction() {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator) {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator,int denominator) {
        _numerator = numerator;
        _denominator = denominator;
    }
    // public void GetFractionString() {
    //     _fractionString = $"{_numerator}/{_denominator}";
    //     Console.WriteLine(_fractionString);
    // }
    // public void GetDecimalValue() {
    //     _fractionValue = _numerator/_denominator;
    //     Console.WriteLine(_fractionValue);
    // }

    // Setter methods:
    public void DenominatorSetter(int denominator) {
        _denominator = denominator;
    }
    public void NumeratorSetter(int numerator) {
        _numerator = numerator;
    }

    // Getter methods:
    public double GetDecimalValue() {
        _fractionValue = _numerator/_denominator;
        double FractionValue = _fractionValue;
        return FractionValue;
    }

    public string GetFractionString() {
        _fractionString = $"{_numerator}/{_denominator}";
        string FractionString = _fractionString;
        return FractionString;
    }

}