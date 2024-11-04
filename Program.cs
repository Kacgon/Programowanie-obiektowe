using Laboratorium_3;
using System;

Person[] people = new Person[]
{
      new Person("Jan", "Nowak", 42),
      new Person("Janina", "Kluz", 52),
      new Person("tomek", "Kud", 32),
      new Person("ela", "Nowakowski", 25),
      new Person("Marek", "Sapkowski", 18)
};
Book[] books = new Book[]
{
    new Book("tytul 1",people[0], 2003),
    new Book("tytul 2",people[1], 2005),
    new Book("tytul 3",people[2], 1934),
    new Book("tytul 4",people[3], 2004),
    new Book("tytul 5",people[4], 1987)
};

Reader czytelnik1 =  new Reader("Eryk","Jaki", 32, [books[0], books[1]]);
Reader czytelnik2 = new Reader("Tomek", "Czytacz", 18, [books[3], books[2], books[4]]);
Reviewer krytyk1 = new Reviewer("Kacper", "Poplot", 20, [books[0], books[4]]);
Reviewer krytyk2 = new Reviewer("Arek", "Wolski", 45, [books[1], books[0], books[3]]);
AdventureBook przygodowa = new AdventureBook("przygodowa", people[0], 2005, "dune");

krytyk1.ViewReviews();
krytyk2.ViewReviews(); 



//Console.WriteLine("===== Książki w systemie =====");
//foreach (Book book in books)
//book.View();

//Console.WriteLine("===== Osoby w systemie =====");
//foreach (Person person in people)
//    person.View();