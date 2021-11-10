using System;

namespace ShopingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            int profileType;
            string userId;
            string password;

            

            Console.WriteLine("PRESS 1 : FOR ADMIN");
            Console.WriteLine("PRESS 2 : FOR USER");

            profileType = Convert.ToInt16(Console.ReadLine());

            if (profileType == 1)
            {
                Console.WriteLine("- - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - ");
                Console.WriteLine("ENTER THE USER ID AND PASSWORD");
                userId = Console.ReadLine();
                password = Console.ReadLine();

                if (userId.Equals("Admin") && password.Equals("admin123"))
                {
                    Console.WriteLine("WELCOME ADMIN");
                    admin();
                }

                else
                {
                    Console.WriteLine("INVALID DATA");
                }
            }

            else if(profileType ==2)
            {
                Console.WriteLine("- - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - ");
                Console.WriteLine("ENTER THE USER ID AND PASSWORD");
                userId = Console.ReadLine();
                password = Console.ReadLine();
                if (userId.Equals("User") && password.Equals("user123"))
                {
                    Console.WriteLine("WELCOME USER");
                    user();
                }

                else
                {
                    Console.WriteLine("INVALID DATA");
                }
            }
        }

        public static void user()
        {
            ProductDeatels p = new ProductDeatels();
            p.productList();
            p.showProduct();

            OrderProductByUser o = new OrderProductByUser();
            o.placeOrder();
        }


        public static void admin()
        {
            ProductDeatels p = new ProductDeatels();
            p.productList();
            p.showProductForAdmin();

            Admin a = new Admin();
            a.stockManagement();
        }
    }
}
