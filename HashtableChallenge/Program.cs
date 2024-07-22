using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Challenge:
  Write a program that wil iterate through each element of the students array and insert them into a hashtable.
  If a student with the same ID already exists in the gashtable skip it and display the following error:
    "Sorry, A student with the same ID already Exists".
  Hint: Use the method ContainsKey() to check wether a student with the same ID already exits.
 */

namespace HashtableChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student[] student = new Student[5];

            student[0] = new Student(1, "El Kumi", 99f);
            student[1] = new Student(2, "Tony", 99f);
            student[2] = new Student(6, "Jon", 100f);
            student[3] = new Student(1, "Glover", 90f);
            student[4] = new Student(4, "Jose", 96f);


            foreach (Student s in student)
            {
                if (!studentsTable.ContainsKey(s.Id))
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine($"Student with Id {s.Id} added");
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID {0} already Exists", s.Id);
                }
            }

            foreach (DictionaryEntry entry in studentsTable)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }

        public override string ToString()
        {
            return $"Student ID {Id}, Name {Name}, GPA {GPA}";
        }
    }

}
