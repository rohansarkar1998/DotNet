using System;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e = new Employe();
            Console.WriteLine("ENTER THE ID AND NAME AND SALARY");
            e.ID = int.Parse(Console.ReadLine());
            e.Name = Console.ReadLine();
            e.Salary = double.Parse(Console.ReadLine());
            e.displayPersonalDetails();
            Console.WriteLine("HIS SALARY IS " + e.displaySalary());
            

        }
    }
}
