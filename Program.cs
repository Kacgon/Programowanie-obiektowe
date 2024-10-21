void Zadanie2()
{
    int a, b;
    bool z = true;

    while (z == true)
    {
        Console.WriteLine("---------Kalkulator---------\n1. suma\n2. Roznica\n3.Iloczyn" +
        "\n4.Iloraz\n5.Potegowanie\n6. Pierwiastkowanie\n7.Trygonometria\n8.Wyjscie");
    
    Console.WriteLine("Podaj 1 liczbe");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj 2 liczbe");
    b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Wybierz rodzaj operacji");
    int choice = Convert.ToInt32(Console.ReadLine());

    
    switch (choice)
    {
        case 1: Total(); break;
        case 2: Difference(); break;
        case 3: ProductNumber(); break;
        case 4: QuotientNumber(); break;
        case 5: SquareNumber(); break;
        case 6: PotentationNumber(); break;
        case 7: TrigonometryNumber(); break;
        case 8: Close(); break;

        default:
            Console.WriteLine("Bledne dane, wpisz poprawne");
            break;
    }
    }
    void Total()
    {
        int wynik = a + b;
        Console.WriteLine(wynik);

    }

    void Difference()
    {
        int wynik = a + b;
        Console.WriteLine(wynik);
    }

    void ProductNumber()
    {
        int wynik = a * b;
        Console.WriteLine(wynik);
    }
    void QuotientNumber()
    {
        int wynik = a/b;
        Console.WriteLine(wynik);
    }
    void SquareNumber()
    {
        double wynik = Math.Pow(a, b);
        Console.WriteLine(wynik);   
    }

    void PotentationNumber() {
        double Liczba1 = Convert.ToDouble(a);
        double wynikA = Math.Sqrt(Liczba1);
    }

    void TrigonometryNumber()
    {
        Console.WriteLine("Podaj liczbe do wykonania funkcji");
        double liczba = Convert.ToDouble(Console.ReadLine());

        double sinus = Math.Sin(liczba);
        double tangens = Math.Tan(liczba);
        double cosinus = Math.Cos(liczba);

        Console.WriteLine($"Sinus wynosi{sinus}, tangens wynosi{tangens} a cosinus {cosinus}");
    }

    void Close()
    {
        Console.WriteLine("Koniec programu");
        System.Environment.Exit(1);
    }
}

Zadanie2();