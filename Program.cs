using System.Diagnostics.CodeAnalysis;

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

//Zadanie2();

void Zadanie3()
{
    int i = 0;
    List<int> liczby = new List<int>();

    while (i < 10)
    {
        Console.Write($"podaj liczbe nr {i + 1}");
        int number = Convert.ToInt32(Console.ReadLine());
        liczby.Add(number);
        i++;
    }
    
    void podpunktA()
    {
        foreach (int numer in liczby)
        {
            Console.WriteLine(numer);
        }
    }
    void podpunktB()
    {
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(liczby[i]);
        }
    }
    void podpunktC()
    {
        Console.WriteLine("Nie parzyste");
        foreach (int numer in liczby)
        {
            int index = liczby.IndexOf(numer);
            if (index % 2 == 0)
            {
                Console.WriteLine(numer);
            }
        }

    }
    void podpunktD()
    { Console.WriteLine("Parzyste");
        foreach (int numer in liczby)
        {
            int index = liczby.IndexOf(numer);
            if (index % 2 == 1)
            {
                Console.WriteLine(numer);
            }
        }

    }
    podpunktA();
    podpunktB();
    podpunktC();
    podpunktD();
}
//zadanie 4
void zadanie4()
{
    int i = 0;
    List<int> liczby = new List<int>();

    while (i < 10)
    {
        Console.Write($"podaj liczbe nr {i + 1}");
        int number = Convert.ToInt32(Console.ReadLine());
        liczby.Add(number);
        i++;
    }

    Console.WriteLine("---------Kalkulator---------\n1. suma\n2. iloczyb\n3.srednia" +
         "\n4.min\n5.max");

    Console.WriteLine("Wybierz rodzaj operacji");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        int suma = 0;
        foreach (int numer in liczby)
        {
            suma = suma + numer;
        }
        Console.WriteLine(suma);
    }
    else if (choice == 2)
    {
        int iloczyn = 1;
        foreach (int numer in liczby)
        {
            iloczyn *= numer;
        }
        Console.WriteLine(iloczyn);
    }
    else if (choice == 3) 
    {
        double suma = 0;
        double ilosc = liczby.Count;
        
       foreach (int numer in liczby)
        {
            suma = suma + numer;
        }
        Console.WriteLine(suma / ilosc);
    }
    else if (choice == 4) 
    {
        int min = liczby.Min();
        Console.WriteLine(min);
    }
    else if (choice == 5)
    {
        int max = liczby.Max();
        Console.WriteLine(max);
    }
}
void zadanie5()
{
    for (int i = 1; i <= 20; i++)
    {
        int[] niepoprawne = { 2, 6, 9, 15, 19 };
        if (niepoprawne.Contains(i))
        {
            continue;
        }
            Console.WriteLine(i);
    }
}

void zadanie6()
{
    while (true)
    {
        Console.WriteLine("Podaj liczbe całkowita");
        int podana = Convert.ToInt32(Console.ReadLine());
        if (podana > 0) 
        { 
            Console.WriteLine(podana);
        }
        else
        {
            break;
        }
    }
}
void zadanie7()
{
    Console.WriteLine("podaj ile chcesz liczb");
    int ilosc = Convert.ToInt32(Console.ReadLine());
    List<int> liczby = new List<int>();

    for (int i = 1; i <= ilosc; i++) 
    {
        Console.Write($"podaj liczbe nr {i}");
        int number = Convert.ToInt32(Console.ReadLine());
        liczby.Add(number);
    }
    int temporary;
    for (int j = 0; j < liczby.Count(); j++)
    {
        for (int i = 0; i < liczby.Count() - 1; i++)
        {
            if (liczby[i] > liczby[i + 1])
            {
                temporary = liczby[i + 1];
                liczby[i + 1] = liczby[i];
                liczby[i] = temporary;
            }
        }
    }

    foreach (int p in liczby)
    {
        Console.WriteLine(p);
    }
}
zadanie7();