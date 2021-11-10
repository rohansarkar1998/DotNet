using System;

namespace Method_Calling
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
            double finalSalary = calculateSalary(da:ref da, salary : salary,pf: out pf, hra : ref hra);
            // This is called name veriable where it doest not depend on the sequence of the function calling and function body.
            
            double finalSalary = calculateSalary(ref hra,ref da,out pf);  // optional veriable if the value not passed it take default value.
            Console.Write("The HRA is = " + hra);  
            Console.Write("The da is = " + da);    
            Console.Write("The PF is = " + pf); 
            Console.WriteLine("EmpNo = " + empNo + "Salary = " + finalSalary);

        }

        static double calculateSalary( ref double hra, ref double da, out double pf,int salary = 1000)
        {
            hra = hra * salary;
            da = da * salary;
            double final = salary + da + hra;
            pf = salary * 0.10; // Out veriable have to initilize inside the funtion.
            return (final);
        }
    }
}

