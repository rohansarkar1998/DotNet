using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassDemo
{
    partial class Employe
    {
        double salary;

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public double displaySalary()
        {
            double finalSalary = salary + (salary * 0.15) + (salary * 0.20);
            return (finalSalary);
        }
    }
}
