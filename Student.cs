using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    public class Student
    {
        private string first_name;
        private string last_name;
        private int[] grades {  get; set; }

        public Student(string first_name, string last_name, int[] grades)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.grades = grades;
        }

        public void View()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void Average()
        {
            Console.WriteLine(grades.Average());
        }

        public void AddGrade() 
        {
            Console.WriteLine("Podaj ocene do dodania");
            int newGrade = Convert.ToInt32(Console.ReadLine());

            grades = [..grades, newGrade];

            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
