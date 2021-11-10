using System;

namespace Structure_Method
{
    class Program
    {
        struct StudentLone
        {
            public string name;    // public so that it can accesss outside the structure body
            public double loneAmmount;
            public double depositeAmmount;

            public double remainning()     // method inside structure body.
            {
                return (loneAmmount - depositeAmmount);
            }
        }
        static void Main(string[] args)
        {
           
            StudentLone s1;
            Console.WriteLine("Name");
            s1.name = Console.ReadLine();
            Console.WriteLine("Lone ammount");
            s1.loneAmmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposite Ammount");
            s1.depositeAmmount = Convert.ToDouble(Console.ReadLine());
            double left = leftAmmount(s1);
            Console.WriteLine(s1.name + "  " + left);
            Console.WriteLine(s1.name + "     " + s1.remainning());   // calling method inside structure body.
        }

        static double leftAmmount(StudentLone s)  // passing structure to the method
        {
            return (s.loneAmmount - s.depositeAmmount);
        }
    }
}
