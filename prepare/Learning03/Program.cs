using System;

class Program
{
    static void Main(string[] args)
    {
        FractionClass createFraction1 = new FractionClass();
        createFraction1.SetNumerator(3);
        createFraction1.SetDenominator(4);
        Console.WriteLine(createFraction1.GetFractionString());
        Console.WriteLine(createFraction1.GetDecimalValue());

        FractionClass createFraction2 = new FractionClass();
        createFraction2.SetNumerator(5);
        createFraction2.SetDenominator(6);
        Console.WriteLine(createFraction2.GetFractionString());
        Console.WriteLine(createFraction2.GetDecimalValue());
        
        FractionClass createFraction3 = new FractionClass();
        createFraction3.SetNumerator(7);
        createFraction3.SetDenominator(8);
        Console.WriteLine(createFraction3.GetFractionString());
        Console.WriteLine(createFraction3.GetDecimalValue());
        
        FractionClass createFraction4 = new FractionClass();
        createFraction4.SetNumerator(6);
        createFraction1.SetDenominator(9);
        Console.WriteLine(createFraction4.GetFractionString());
        Console.WriteLine(createFraction4.GetDecimalValue());
        
    }
}