using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart
{
    class OrderProductByUser
    {
        int id;
        int number;
        int choice = 1;
        ProductManagement p = new ProductManagement();
        public void placeOrder()
        {

            p.creatList();
            do
            {
                Console.WriteLine("ENTER THE PRODUCT ID AND PRODUCT NUMBER");
                id = Convert.ToInt16(Console.ReadLine());
                number = Convert.ToInt16(Console.ReadLine());

                Dictionary<int, int> order = new Dictionary<int, int>();
                order.Add(id, number);

                p.placeOrder(order);

                Console.WriteLine("DO YOU WANT TO CONTINUE :   1. YES : 2.NO");
                choice = Convert.ToInt16(Console.ReadLine());
            }

            while (choice == 1);

            p.generateBill();
        }
    }
}
