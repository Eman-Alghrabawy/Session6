namespace Session6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.ID = 1;
            emp.Name = "Eman";
            emp.SecurityLevel = "Admin";
            emp.Salary = 15000;
            emp.HireDate = new DateTime(2025, 10, 5);
            emp.Gender = 'F';
        }
    }
}
