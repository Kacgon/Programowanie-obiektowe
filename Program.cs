//using Lab_7_OOp;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

////Console.WriteLine("Podaj swoj nr albumu");
////string album = Console.ReadLine();
////Console.WriteLine(album);
////Console.WriteLine("Podaj tekst do pliku");
////string tekst = Console.ReadLine();

////string path = $"{album}.txt";
////string content = $"{tekst}";


////File.WriteAllText(path, content);
////System.Console.WriteLine("Plik został utworzony.");


////string sprawdzenie = File.ReadAllText(path);
////System.Console.WriteLine("Zawartość pliku: " + sprawdzenie);


////using Newtonsoft.Json;
////using System;

////string path = "pesels.txt";
////string sprawdzenie = File.ReadAllText(path);
////Console.WriteLine("Zawartość pliku: " + sprawdzenie);
////int sumaFemale = 0; 
////static List<string> ZamienDaneNaListe(string plik)
////{
////    return File.ReadAllLines(plik).ToList();
////}

////foreach(string pesel in ZamienDaneNaListe(path))
////{
////    Console.WriteLine(pesel);
////    if (pesel[9] % 2 == 0)
////    {
////        sumaFemale = sumaFemale + 1;
////    }

////}
////Console.WriteLine(sumaFemale);

//class Program
//{
//    static void Main(string[] args)
//    {
//        string json = File.ReadAllText("db.json");
//        var rekordy = JsonConvert.DeserializeObject<List<Record>>(json);

//        var populationData = rekordy
//            .Where(r => r.Value != null) 
//            .GroupBy(r => r.Country.Value)
//            .ToDictionary(
//                g => g.Key,
//                g => g.ToDictionary(
//                    r => int.Parse(r.Date),
//                    r => long.Parse(r.Value)
//                )
//            );

//        while (true)
//        {
//            Console.WriteLine("Wybierz operacje");
//            Console.WriteLine("1 indie miedzy 1970 a 2000");
//            Console.WriteLine("2 usa miedzy 1965 a 2010 ");
//            Console.WriteLine("3 Chinach między 1980 a 2018 ");
//            Console.WriteLine("4 Wyświetl kraj w tym roku");
//            Console.WriteLine("5 roznica dla kraju w zakres");
//            Console.WriteLine("6 procent wzrostu ");
//            Console.WriteLine("7 Wyjdź");

//            string option = Console.ReadLine();
//            switch (option)
//            {
//                case "1":
//                    RoznicaLudzi(populationData, "India", 1970, 2000);
//                    break;
//                case "2":
//                    RoznicaLudzi(populationData, "United States", 1965, 2010);
//                    break;
//                case "3":
//                    RoznicaLudzi(populationData, "China", 1980, 2018);
//                    break;
//                case "4":
//                    ludnoscDlaRokuWKraju(populationData);
//                    break;
//                case "5":
//                    ludnoscDlaPodanego(populationData);
//                    break;
//                case "6":
//                    procentowaRoznica(populationData);
//                    break;
//                case "7":
//                    return;
//                default:
//                    Console.WriteLine("niepoprawny numer ");
//                    break;
//            }
//        }
//    }

//    static void RoznicaLudzi(Dictionary<string, Dictionary<int, long>> data, string country, int rokPocz, int rokKon)
//    {
//        if (data.ContainsKey(country) && data[country].ContainsKey(rokPocz) && data[country].ContainsKey(rokKon))
//        {
//            long wynik = data[country][rokKon] - data[country][rokPocz];
//            Console.WriteLine($"roznica w {country} między {rokPocz} a {rokKon}: {wynik}");
//        }
//    }

//    static void ludnoscDlaRokuWKraju(Dictionary<string, Dictionary<int, long>> data)
//    {
//        Console.WriteLine("podaj Kraj");
//        string kraj = Console.ReadLine();

//        Console.WriteLine("podaj rok");
//        if (int.TryParse(Console.ReadLine(), out int year) && data.ContainsKey(kraj) && data[kraj].ContainsKey(year))
//        {
//            Console.WriteLine($"ludnosc w {kraj} rok {year}: {data[kraj][year]}");
//        } 
//    }

//    static void ludnoscDlaPodanego(Dictionary<string, Dictionary<int, long>> data)
//    {
//        Console.WriteLine("Podaj kraj");
//        string country = Console.ReadLine();

//        Console.WriteLine("Podaj pierwszy rok");
//        int year1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Podaj drugi rok");
//        int year2 = int.Parse(Console.ReadLine());

//        if (data.ContainsKey(country) && data[country].ContainsKey(year1) && data[country].ContainsKey(year2))
//        {
//            long diff = data[country][year2] - data[country][year1];
//            Console.WriteLine($"roznica w {country} to {diff}");
//        }
//    }

//    static void procentowaRoznica(Dictionary<string, Dictionary<int, long>> data)
//    {
//        foreach (var country in data.Keys)
//        {
//            Console.WriteLine($"\n{country}:");
//            var years = data[country].Keys.OrderBy(y => y).ToList();

//            for (int i = 1; i < years.Count; i++)
//            {
//                int prevYear = years[i - 1];
//                int currYear = years[i];
//                double growth = ((double)data[country][currYear] - data[country][prevYear]) / data[country][prevYear] * 100;
//                Console.WriteLine($"{prevYear} {currYear}{growth:F2}%");
//            }
//        }
//    }
//}



