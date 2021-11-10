using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart
{
    class Admin
    {
        int id;
        int number;
        int choice;
        int n = 1;
        ProductManagement p = new ProductManagement();
        public void stockManagement()
        {
            p.creatList();


            do { 
            Console.WriteLine("1. UPDATE STOCK");
            Console.WriteLine("2. ADD NEW STOCK");
            Console.WriteLine("3. REMOVE STOCK");
            Console.WriteLine("4. CHECK STOCK");

            choice =Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Dictionary<int, int> update = new Dictionary<int, int>();
                        Console.WriteLine("ENTER THE PRODUCT ID AND NUMBER");
                        id = Convert.ToInt16(Console.ReadLine());
                        number = Convert.ToInt16(Console.ReadLine());
                        update.Add(id, number);
                        p.updateStock(update);
                        break;
                    case 2:
                        Product input = inputDetails();
                        p.addNewProduct(input);
                        break;
                    case 3:
                        Console.WriteLine("ENTER THE PRODUCT ID ");
                        id = Convert.ToInt16(Console.ReadLine());
                        p.removeStock(id);
                        break;
                    case 4:
                        p.showStock();
                        break;

                        
                }
                Console.WriteLine("Do you want to continue :  1:YES  2:NO");
                n =Convert.ToInt16(Console.ReadLine());
            }

            while (n == 1);

        }


        public static Product inputDetails()
        {
            Product p = new Product();
            Console.WriteLine("ENTER THE PRODUCT TYPE, PRODUCT BRAND, PRODUCT NAME, PRICE, PRODUCT AMMOUNT");

            p.productType = Console.ReadLine();
            p.productBrand = Console.ReadLine();
            p.productName = Console.ReadLine();
            p.price = Convert.ToInt16(Console.ReadLine());
            p.productAmmount = Convert.ToInt16(Console.ReadLine());

            return p;

        }
    }
}
