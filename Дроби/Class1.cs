public class Fraction
{
    public int Numerator;
    public int Denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public void Print()
    {
        Console.WriteLine($"{Numerator}/{Denominator}");
    }

    public void SumFraction(Fraction secondFraction)
    {
        Numerator *= secondFraction.Denominator;
        secondFraction.Numerator *= Denominator;
        Denominator *= secondFraction.Denominator;
        Numerator += secondFraction.Numerator;
        Console.WriteLine(ReductionFraction());
    }

    public void SubtractionFraction(Fraction secondFraction)
    {
        Numerator *= secondFraction.Denominator;
        secondFraction.Numerator *= Denominator;
        Denominator *= secondFraction.Denominator;
        Numerator -= secondFraction.Numerator;
        Console.WriteLine(ReductionFraction);
    }

    public void MultiplicationFraction(Fraction secondFraction)
    {
        Numerator *= secondFraction.Denominator;
        Denominator *= secondFraction.Denominator;
        Console.WriteLine(ReductionFraction);
    }

    public void DivideFraction(Fraction secondFraction)
    {
        Numerator *= secondFraction.Denominator;
        Denominator *= secondFraction.Numerator;
        Console.WriteLine(ReductionFraction);
    }

    public string ReductionFraction()
    {
        if (Numerator % Denominator == 0) return $"Ваша сокращенная дробь: {Numerator / Denominator}";
        for (int i = 1; i < Numerator; i++)
        {
            if (Numerator % i == 0 && Denominator % i == 0)
            {
                Numerator /= i;
                Denominator /= i;
            }
        }
        return $"Ваша сокращенная дробь: {Numerator}/{Denominator}";
    }
}