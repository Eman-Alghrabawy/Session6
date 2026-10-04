using System;
using System.Collections.Generic;
using System.Text;

namespace Session6
{
    //enum Gender
    //{
    //    M,
    //    F
    //}

    //enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA,
    //    SecurityOfficer
    //}
    //internal class Employee
    //{
    //   public int ID { get; set; }
    //   public string Name { get; set; }
    //    //public string SecurityLevel { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //   public DateTime HireDate { get; set; }
    //    //public char Gender { get; set; }
    //    public Gender Gender { get; set; }
    //    public override string ToString()
    //    {
    //        return String.Format(
    //            "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
    //            ID,
    //            Name,
    //            SecurityLevel,
    //            Salary,
    //            HireDate,
    //            Gender
    //        );
    //    }
    //    }


    //class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }
    //}



    //class Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public Shape(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public double Area()
    //    {
    //        return Width * Height;
    //    }

    //    public override string ToString()
    //    {
    //        return $"(Width = {Width}, Height = {Height})";
    //    }


    //}
    //class Cube : Shape
    //{
    //    public double Depth { get; set; }

    //    public Cube(double width, double height, double depth)
    //        : base(width, height)
    //    {
    //        Depth = depth;
    //    }

    //    public new double Area()
    //    {
    //        return base.Area() * Depth;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Width = {Width}, Height = {Height}, Depth = {Depth}");
    //    }
    //}


    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a person's basic data. Person.");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
        }
    }


    class Doctor : Person
    {
        public string Specialty { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am a Doctor.");
        }

        public override void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Specialty: {Specialty}");
        }
    }

    class Engineer : Person
    {
        public string Field { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Field: {Field}");
        }
    }
}
