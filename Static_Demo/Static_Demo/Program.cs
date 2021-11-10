using System;

namespace Static_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            m1.countId();
            Console.WriteLine("Hello");
            m1.countId();
            Console.WriteLine("Hello");
            m1.countId();
            Console.WriteLine("Hello");
            m1.countId();
        }
    }
}
