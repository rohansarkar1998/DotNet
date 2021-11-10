using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeDetails e = new EmployeDetails();
            Console.WriteLine("ENTER THE ID");
            e.Id = Convert.ToInt16((Console.ReadLine()));
            e.name = "Rohan";
            Console.WriteLine("ENTER THE BASIC PAY");
            e.BasicPay = int.Parse(Console.ReadLine());
            Console.WriteLine("ID    :" + e.Id + "Name   :" + e.name + "Salary   :"+e.calculateSalary());
        }
    }
}
