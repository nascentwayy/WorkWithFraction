Console.WriteLine("Вы зашли в программу, которая проводит разнообразные операции с дробями!");
Console.WriteLine("Ввести первую дробь - введите '1'.\nВвести целое число - введите '2'.");
string userAnswer = Console.ReadLine();
Fraction firstFraction;
while (true)
{
    if (userAnswer == "1")
    {
        Console.Write("Введите числитель для первой дроби: ");
        int numerator = GetDigitAfterVerification(Console.ReadLine());
        Console.Write("Введите знаменатель для первой дроби: ");
        int denominator = GetDigitForDenominatorAfterVerification(Console.ReadLine());


        firstFraction = new Fraction(numerator, denominator);
        firstFraction.Numerator = numerator;
        firstFraction.Denominator = denominator;
        Console.Write("Первая дробь: ");
        firstFraction.Print();
        break;
    }
    else if (userAnswer == "2")
    {
        Console.Write("Введите ваше число: ");
        int numerator = GetDigitAfterVerification(Console.ReadLine());

        firstFraction = new Fraction(numerator, 1);
        firstFraction.Numerator = numerator;
        Console.Write("Первая дробь: ");
        firstFraction.Print();
        break;
    }
    else
    {
        Console.WriteLine("Пожалуйста, проверь введенные данные.\nВвести дробь - введите '1'.\nВвести целое число - введите '2'.");
        userAnswer = Console.ReadLine();
    }
}

Console.WriteLine("Ввести вторую дробь - введите '1'.\nВвести целое число - введите '2'.");
userAnswer = Console.ReadLine();

Fraction secondFraction;
while (true)
{
    if (userAnswer == "1")
    {

        Console.Write("Введите числитель для второй дроби: ");
        int numerator = GetDigitAfterVerification(Console.ReadLine());
        Console.Write("Введите знаменатель для второй дроби: ");
        int denominator = GetDigitForDenominatorAfterVerification(Console.ReadLine());

        secondFraction = new Fraction(numerator, denominator);
        secondFraction.Numerator = numerator;
        secondFraction.Denominator = denominator;
        Console.Write("Вторая дробь: ");
        secondFraction.Print();
        break;
    }
    else if (userAnswer == "2")
    {
        Console.Write("Введите ваше число: ");
        int numerator = GetDigitAfterVerification(Console.ReadLine());

        secondFraction = new Fraction(numerator, 1);
        secondFraction.Numerator = numerator;
        Console.Write("Вторая дробь: ");
        secondFraction.Print();
        break;
    }
    else
    {
        Console.WriteLine("Пожалуйста, проверь введенные данные.\nВвести дробь - введите '1'.\nВвести целое число - введите '2'.");
        userAnswer = Console.ReadLine();
    }
}

firstFraction.SumFraction(secondFraction);


static int GetDigitAfterVerification(string digit)
{
    while (true)
    {
        try
        {
            int digitVerif = int.Parse(digit);
            return digitVerif;
        }
        catch
        {
            Console.Write("Проверьте правильность введенных данных! Введите ЧИСЛО: ");
            digit = Console.ReadLine();
        }
    }
}

static int GetDigitForDenominatorAfterVerification(string digit)
{
    int digitVerif = GetDigitAfterVerification(digit);
    while (true)
    {
        if (digitVerif == 0)
        {
            Console.Write("Проверьте правильно введенных данных! Знаменатель не может быть равен нулю! ");
            digitVerif = GetDigitAfterVerification(Console.ReadLine());
        }
        else return digitVerif;
    }
}