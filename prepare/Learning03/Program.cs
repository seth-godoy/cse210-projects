using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.SetTop(2);
        fraction1.SetBottom(4);
        int numerator1 = fraction1.GetTop();
        int denominator1 = fraction1.GetBottom();

        fraction2.SetTop(10);
        fraction2.SetBottom(5);
        int numerator2 = fraction2.GetTop();
        int denominator2 = fraction2.GetBottom();

        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        int numerator3 = fraction3.GetTop();
        int denominator3 = fraction3.GetBottom();

        // Fraction 1
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue() + "\n");

        // Fraction 2
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue() + "\n");

        // Fraction 3
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue() + "\n");
    }
}