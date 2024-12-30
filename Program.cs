using Laboratorium_OOP_5;
using System;
using System.Drawing;

//static void Kalkulator()
//{
//    Console.WriteLine("Podaj liczbe 1");
//    int liczba1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("podaj liczbe2");
//    int liczba2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("wybierz operacje +.1  -.2  *.3  /.4");
//int wybrana = Convert.ToInt32(Console.ReadLine());
//Array wartosci = Enum.GetValues(typeof(operacjeMatematyczne));
//operacjeMatematyczne costam = (operacjeMatematyczne)wartosci.GetValue(wybrana - 1);


//    try
//    {
//        int efektOperacji = ObliczDzialanie(costam, liczba1, liczba2);

//        Console.WriteLine(efektOperacji);
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"nie dziel przez 0: {ex.Message}");
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("podales string a nie liczbe");
//    }
//    finally {
//    Console.WriteLine("koncowy wynik");
//    }
//}

//static int ObliczDzialanie(operacjeMatematyczne operacja, int liczba1, int liczba2)
//{

//        switch (operacja)
//        {

//            case operacjeMatematyczne.dodawanie:
//                return liczba1 + liczba2;
//            case operacjeMatematyczne.odejmowanie:
//                return liczba1 - liczba2;
//            case operacjeMatematyczne.mnozenie:
//                return liczba1 * liczba2;
//            case operacjeMatematyczne.dzielenie:
//                return liczba1 / liczba2;
//            default:
//                throw new ArgumentOutOfRangeException();

//        }

//}
//Kalkulator();


//zad 2

//Dictionary<int,(StatusZamowienia, List<string>)> zamowienia = new Dictionary<int, (StatusZamowienia, List<string>)>();
//zamowienia[0] =  (StatusZamowienia.Zrealizowane, new List<string> { "Telewizor"});
//zamowienia[1] = (StatusZamowienia.Oczekujące, new List<string> { "Telefon", "Myszka", "Xbox" });
//zamowienia[2] = (StatusZamowienia.Przyjęte, new List<string> { "Pralka", "Lampa" });

//static void ChangeStatus(Dictionary<int, (StatusZamowienia, List<string>)> zamowienia)
//{
//    Console.WriteLine("Jakie zamowienie chcesz zaktualizowac");
//    int wybrane = Convert.ToInt32(Console.ReadLine());

//    try
//    {
//        Console.WriteLine(zamowienia[wybrane].Item1);
//        Console.WriteLine("na jaki status chcesz zmienic :1 oczekujace, 2 przyjete, 3 zrealizowane, 4 anulowane");
//        int wybrana = Convert.ToInt32(Console.ReadLine());
//        Array statusy = Enum.GetValues(typeof(StatusZamowienia));
//        StatusZamowienia zaktualizowanyStatus = (StatusZamowienia)statusy.GetValue(wybrana - 1);

//        zamowienia[wybrane] = (zaktualizowanyStatus, zamowienia[wybrane].Item2);
//        Console.WriteLine(zamowienia[wybrane].Item1);

//    } 
//    catch (KeyNotFoundException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (ArgumentException ex)
//    {
//        Console.WriteLine(ex.Message );
//    }
   
//}


//static void ShowOrders(Dictionary<int, (StatusZamowienia, List<string>)> zamowienia)
//{
//    foreach (var przedmiot in zamowienia)
//    {
//        Console.WriteLine($"Id: {przedmiot.Key}");
//        Console.WriteLine($"Status zamowienia: {przedmiot.Value.Item1}");
//        Console.WriteLine("Przedmioty:");
//        foreach (var fruit in przedmiot.Value.Item2) 
//        {
//            Console.WriteLine($"- {fruit}");
//        }
//    }
//}
//ShowOrders(zamowienia);
//ChangeStatus(zamowienia);

//zad 3

static void ZgadywanieKoloru()
{
    List<Kolory> list = new List<Kolory>() {Kolory.Czerwony,Kolory.Niebieski,Kolory.Zielony,Kolory.Żółty,Kolory.Fioletowy };
    Random rand = new Random();
    int randomIndex = rand.Next(0, list.Count);
    Kolory wylosowany = list[rand.Next(list.Count)];
    Console.WriteLine(wylosowany.ToString());

    Console.WriteLine("Wybierz kolor z dostępnych na w tej liście");
    foreach (var kolory in list)
    {
        Console.WriteLine(kolory.ToString() );
    }
    
    bool sukces = false;

    
        while (sukces == false) 
        {
            string podana = Console.ReadLine();
            Kolory podanyKolor = (Kolory)Enum.Parse(typeof(Kolory), podana, true);
        try
        {
            if (podanyKolor == wylosowany)
            {
                Console.WriteLine("Zgadles");
                sukces = true;
            }
            else
            {
                Console.WriteLine("Sprobuj ponownie");
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Nie ma takiego koloru w dostepnych");
        }
    }
       }
ZgadywanieKoloru();