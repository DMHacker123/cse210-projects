using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();       // 1/1
        Fraction f2 = new Fraction(5);      // 5/1
        Fraction f3 = new Fraction(3, 4);   // 3/4
        Fraction f4 = new Fraction(1, 3);   // 1/3

        Print(f1);
        Print(f2);
        Print(f3);
        Print(f4);
    }

    static void Print(Fraction f)
    {
        Console.WriteLine($"Fraction: {f.ToFractionString()}");
        Console.WriteLine($"Decimal: {f.ToDecimal()}\n");
    }
}
