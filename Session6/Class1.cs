using System;
using System.Collections.Generic;
using System.Text;

namespace Session6
{
    enum Gender
    {
        M,
        F
    }
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
       public int ID { get; set; }
       public string Name { get; set; }
        //public string SecurityLevel { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
       public DateTime HireDate { get; set; }
        //public char Gender { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return String.Format(
                "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                ID,
                Name,
                SecurityLevel,
                Salary,
                HireDate,
                Gender
            );
        }
        }


    //class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }
    //}



}
