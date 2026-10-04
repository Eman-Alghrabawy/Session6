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
    internal class Employee
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public string SecurityLevel { get; set; }
       public decimal Salary { get; set; }
       public DateTime HireDate { get; set; }
        //public char Gender { get; set; }
        public Gender Gender { get; set; }
    }


    //class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }
    //}



}
