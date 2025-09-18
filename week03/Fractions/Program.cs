using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFract = new Fraction();
        Fraction secFract = new Fraction(6);
        Fraction thirdFrac = new Fraction(6, 7);

        thirdFrac.SetTop(15);
        thirdFrac.SetBottom(25);

        Console.WriteLine(thirdFrac.GetFractionString());
        Console.WriteLine(thirdFrac.GetDecimalValue());
    }
}