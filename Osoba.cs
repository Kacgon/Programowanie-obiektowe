using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{

         public class Osoba : IOsoba
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return $"{imie} {nazwisko}";
        }
    
        string pesel;

        public Osoba(string imie,string nazwisko, string pesel) 
        {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pesel = pesel;
        }

        public string GetPsl()
        {
            return pesel;
        }
        public virtual void  SetFirstName(string firstName) 
        {
            this.imie = firstName;
        }
        public virtual void SetLastName(string lastName)
        {
            this.nazwisko = lastName;
        }
        public virtual void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }
        public virtual int getAge(string pesel)
        {
            int rok = int.Parse(pesel.Substring(0, 2));
            int mies = int.Parse(pesel.Substring(2, 2));
            int dzien = int.Parse(pesel.Substring(4, 2));

            if (mies > 20) rok += 2000;
            else rok += 1900;

            DateTime birthDate = new DateTime(rok, mies % 20, dzien);
     
            int age = (DateTime.Today).Year - birthDate.Year;
            if (birthDate > (DateTime.Today).AddYears(-age)) age--;

            return age;
        }

        public virtual void CanGoAlone(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("Moze isc sam");
            }
            else 
            {
                Console.WriteLine("Nie moze sam");
            }
        }

        public string getFullName()
        {
            return $"{imie} {nazwisko}";
        }

        public void getEducationInfo(string wyksztalcenie)
        {
            Console.WriteLine($"wyksztalceni: {wyksztalcenie}");
        }

        public void getGender(string pesel)
        {
            if (pesel[11] % 2 == 0) 
            {
                Console.WriteLine("Osoba jest kobieta");
            }
            else 
            {
                Console.WriteLine("Osoba jest mezczyzna");
            }
        }

    }
}
