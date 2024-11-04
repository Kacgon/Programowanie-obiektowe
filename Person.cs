using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        public string FirstName 
        {
            get { return firstName; } 
            set { firstName = value; } 
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void View()
        {
            Console.WriteLine($"Imie: \t{firstName} \t Nazwisko: {lastName} \t{age}");
        }
    }
}
