using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public Person(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public void vorstellen()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Surname: {Surname}");
        }

    }

    // inheritance ist etwas was dir hilft wenn man viele klassen hat die sich ähneln
    // also student und lehrer haben beide eine id, name und surname


    public class Student : Person
    {
        public string MatriculationNumber { get; set; }
        public Student(int id, string name, string surname, string matriculationNumber)
            : base(id, name, surname)
        {
            MatriculationNumber = matriculationNumber;
        }
        public void vorstellen()
        {
            base.vorstellen();
            Console.WriteLine($"Matriculation Number: {MatriculationNumber}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(int id, string name, string surname, string subject)
            : base(id, name, surname)
        {
            Subject = subject;
        }
        public void vorstellen()
        {
            base.vorstellen();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

}
