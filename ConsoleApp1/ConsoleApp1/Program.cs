using System;

//  c# basic and different type of function calling.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Empno,Salary");
            int empNo = Convert.ToInt32(Console.ReadLine());
            int salary = Convert.ToInt32(Console.ReadLine());
            double hra = 0.15;
            double da = 0.20;
            double pf;
            double finalSalary = calculateSalary(salary,ref hra,ref da,out pf);
            Console.Write("The HRA is = " + hra);  // These two are called pass referance. The value chane inside the function also change outside the function.
            Console.Write("The da is = " + da);    // Here we have to initilize the value before the method get called and we have to use the ref keyword.
            Console.Write("The PF is = " + pf); //  This is called out parameter, When the function have to return more than one value.
            Console.WriteLine("EmpNo = " + empNo + "Salary = " + finalSalary);

        }

        static double calculateSalary(int salary , ref double hra, ref double da,out double pf)
        {
            hra = hra * salary;
            da = da * salary;
            double final = salary + da + hra;
            pf = salary * 0.10; // Out veriable have to initilize inside the funtion.
            return (final);
        }
    }
}
