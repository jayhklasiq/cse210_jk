public class FractionClass
{
    private int _numerator;
    private int _denominator;
    public void Fraction()
    {
        _numerator = 1;
        _denominator = 1;
        Console.WriteLine($"{_numerator}/{_denominator}");
    }
    public void Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public string GetNumerator()
    {
        return _numerator.ToString();
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public string GetDenominator()
    {
        return _denominator.ToString();
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public void Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    
    public string GetFractionString()
    {
        string display = $"{_numerator}/{_denominator}";
        return display;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}