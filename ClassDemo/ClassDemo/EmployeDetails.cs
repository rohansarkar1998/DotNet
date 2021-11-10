using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class EmployeDetails
    {
        private int id;
        public string name;
        double basicPay;

        public int Id   // This is similar to java getter and setter.
        {
            get
            {
                return (id);
            }

            set
            {
                id = value;
            }

        }

        public double BasicPay
        {
            get
            {
                return basicPay;
            }

            set
            {
                basicPay = value;
            }
        }

        public double calculateSalary()
        {
            double salary = basicPay + (basicPay * 0.15) + (basicPay * 0.20);
            return (salary);
        }

    }
}
