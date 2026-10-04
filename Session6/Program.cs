namespace Session6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee emp = new Employee();

            //emp.ID = 1;
            //emp.Name = "Eman";
            //emp.SecurityLevel = "Admin";
            //emp.Salary = 15000;
            //emp.HireDate = new DateTime(2025, 10, 5);
            //emp.Gender = 'F';
            //emp.Gender = Gender.F;

            // emp.SecurityLevel = SecurityLevel.Developer;



            //HiringDate date = new HiringDate();

            //date.Day = 5;
            //date.Month = 10;
            //date.Year = 2025;


            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee
            //{
            //    ID = 1,
            //    Name = "Ahmed",
            //    SecurityLevel = SecurityLevel.DBA
            //};

            //EmpArr[1] = new Employee
            //{
            //    ID = 2,
            //    Name = "Omar",
            //    SecurityLevel = SecurityLevel.Guest
            //};

            //EmpArr[2] = new Employee
            //{
            //    ID = 3,
            //    Name = "Eman",
            //    SecurityLevel = SecurityLevel.SecurityOfficer
            //};


            //Shape s = new Shape(10, 5);

            //Console.WriteLine(s.Area());
            //Console.WriteLine(s);

            Cube c = new Cube(10, 5, 2);

            Console.WriteLine(c.Area());
            c.Print();
        }

    }

}
