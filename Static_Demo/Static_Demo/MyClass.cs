using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Demo
{
    class MyClass
    {
         int id=1;

        public void countId()
        {
            Console.WriteLine("This method is call " + id + " number of time");
            id = id + 1;
        }
    }
}
