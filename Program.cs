using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Marks: {Marks}");
    }
}

class Program
{
    static List<Student> studentList = new List<Student>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\nStudent Record Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (choice != 4);
    }

    static void AddStudent()
    {
        Student s = new Student();
        Console.Write("Enter ID: ");
        s.ID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToDouble(Console.ReadLine());
        studentList.Add(s);
        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\nAll Student Records:");
        foreach (Student s in studentList)
        {
            s.Display();
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Student ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        foreach (Student s in studentList)
        {
            if (s.ID == id)
            {
                Console.WriteLine("Student Found:");
                s.Display();
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Student not found.");
        }
    }
}
