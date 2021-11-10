using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassDemo
{
    partial class Employe
    {
         int id;
         String name;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }

        public void displayPersonalDetails()
        {
            Console.WriteLine("ID : "+id + "  name : "+ name);
        }
    }
}
