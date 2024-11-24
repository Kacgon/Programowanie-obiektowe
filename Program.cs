using Laboratorium_OOP_5;
using System;
using System.Drawing;


static void Kalkulator()
{
    Console.WriteLine("Podaj liczbe 1");
    int liczba1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("podaj liczbe2");
    int liczba2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("wybierz operacje +.1  -.2  *.3  /.4");
    int wybrana = Convert.ToInt32(Console.ReadLine());
    Array wartosci = Enum.GetValues(typeof(operacjeMatematyczne));
    operacjeMatematyczne costam = (operacjeMatematyczne)wartosci.GetValue(wybrana-1);


    try
    {
        int efektOperacji = ObliczDzialanie(costam, liczba1, liczba2);

        Console.WriteLine(efektOperacji);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"nie dziel przez 0: {ex.Message}");
    }
    catch (FormatException)
    {
        Console.WriteLine("podales string a nie liczbe");
    }
    finally {
    Console.WriteLine("koncowy wynik");
    }
}

static int ObliczDzialanie(operacjeMatematyczne operacja, int liczba1, int liczba2)
{

        switch (operacja)
        {

            case operacjeMatematyczne.dodawanie:
                return liczba1 + liczba2;
            case operacjeMatematyczne.odejmowanie:
                return liczba1 - liczba2;
            case operacjeMatematyczne.mnozenie:
                return liczba1 * liczba2;
            case operacjeMatematyczne.dzielenie:
                return liczba1 / liczba2;
            default:
                throw new ArgumentOutOfRangeException();

        }
    
}
Kalkulator();


//zad 2