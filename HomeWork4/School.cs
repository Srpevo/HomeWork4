using System;
using System.Collections.Generic;
using System.Drawing;

namespace School
{
    internal class Student
    {
        private static int _nextId = 1; 

        public Student(string name, string surname, int age, string mail, DateTime birth)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative!", nameof(age));
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(mail))
            {
                throw new ArgumentNullException("Name, surname, and email cannot be empty!");
            }
            int calculatedAge = CalculateAge(birth);
            if (calculatedAge != age)
            {
                throw new ArgumentException($"Age does not match date of birth! Specified {age}, but should be {calculatedAge}.");
            }

            Id = _nextId++;
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;
            Birth = birth;
        }

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Mail { get; }
        public DateTime Birth { get; }

        public void PrintStudentData()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Email: " + Mail);
            Console.WriteLine("Birthdate: " + Birth.ToShortDateString());
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }

    internal class SchoolStudents
    {
        private List<Student> students;
        int Size;

        public SchoolStudents(int size)
        {
            students = new List<Student>(size);
            this.Size = size;
        }
        public SchoolStudents()
        {
            students = new List<Student>(5);
            this.Size = 5;
        }
        public void AddStudentsData()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("[Exit] [Clear] [Any (to continue)]");
                string input = Console.ReadLine();
                if (input.ToLower() == "Exit".ToLower()) { break; }
                if (input.ToLower() == "Clear".ToLower()) { students.Clear(); }
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter age:");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter email:");
                string mail = Console.ReadLine();
                Console.WriteLine("Enter date of birth:");

                DateTime birth;
                while (!DateTime.TryParse(Console.ReadLine(), out birth))
                {
                    Console.WriteLine("Invalid date.");
                }
                Student student = new Student(name, surname, age, mail, birth);
                students.Add(student);
            }
        }
        public void ShowAllStudentData()
        {
            foreach (var student in students)
            {
                student.PrintStudentData();
            }
        }
    }
}
