using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeManager e = new EmployeManager();
            int choice = 1;
            do
            {


                Console.WriteLine("1. TO ENTER THE EMPLOYE");
                Console.WriteLine("2. TO SHOW EMPLOYE LIST");
                Console.WriteLine("3. EXIT");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ENTER THE EMPLOYE NAME");
                        string Name = Console.ReadLine();
                        Console.WriteLine("ENTER THE EMPLOYE ID");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER THE EMPLOYE DATE OF JOINING");
                        DateTime Doj = Convert.ToDateTime(Console.ReadLine());
                        IEmploye e1 = new Employe(ID, Name, Doj);
                        e.addEmploye(e1);
                        break;
                    case 2:

                        int i;
                        List<IEmploye> emplist = e.DisplayEmploye();
                        for (i = 0; i < emplist.Count; i++)
                        {
                            Console.WriteLine("ID  : " + emplist[i].ID + " name : " + emplist[i].Name + " Date Of Joining : " + emplist[i].Doj);
                        }
                        break;
                    case 3:
                        break;

                }
            }

            while (choice == 1 || choice == 2);
               

        }  
    }
 }

