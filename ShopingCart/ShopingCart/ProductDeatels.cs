using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart
{
    class ProductDeatels
    {
         List<Product> list = new List<Product>();

        public List<Product> productList()
        {
            Product p1 = new Product(1, "MOBILE", "SAMSUNG", "M51", 25000, 25);
            Product p2 = new Product(2, "MOBILE", "SAMSUNG", "M31", 15000, 35);
            Product p3 = new Product(3, "MOBILE", "REDMI", "10T PRO", 35000, 20);
            Product p4 = new Product(4, "MOBILE", "REALME", "X7 5G", 25000, 20);
            Product p5 = new Product(5, "MOBILE", "ONE PLUS", "8 PRO", 55000, 15);
            Product p6 = new Product(6, "MOBILE", "APPLE", "12 PRO MAX", 125000, 10);
            Product p7 = new Product(7, "LAPTOP", "ASUS", "VIVOBOOK 14", 62000, 15);
            Product p8 = new Product(8, "LAPTOP", "HP", "PAVILION", 65000, 15);
            Product p9 = new Product(9, "LAPTOP", "LENEVO", "IDEAPAD", 65000, 10);
            Product p10 = new Product(10,"LAPTOP", "DELL", "INSPIRON", 75000, 25);
            Product p11 = new Product(11,"LAPTOP", "MICROSOFT", "SYRFACE 7", 125000, 5);
            Product p12 = new Product(12,"LAPTOOP", "APPLE", "MACBOOK", 225000, 5);
            Product p13 = new Product(13,"TABLET", "SAMSUNG", "TAB S7 +", 75000, 15);
            Product p14 = new Product(14,"TABLET", "APPLE", "IPAD PRO", 125000, 5);
            Product p15 = new Product(15,"LAPTOP", "VAIO", "E7", 55000, 15);


            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            list.Add(p7);
            list.Add(p8);
            list.Add(p9);
            list.Add(p10);
            list.Add(p11);
            list.Add(p12);
            list.Add(p13);
            list.Add(p14);
            list.Add(p15);

            return list;

        }

       public void showProduct()
        {

            Console.WriteLine("                               -----------------                   ");


            Console.WriteLine("ID" + "     " + "TYPE" + "     " + "BRAND" + "         " + "NAME" + "             " + "PRICE");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            int i;
            for(i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i].productId + "     " + list[i].productType + "    " + list[i].productBrand + "         " + list[i].productName + "            " + list[i].price);
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }
        }



        public void showProductForAdmin()
        {
            
            

                Console.WriteLine("                               -----------------                   ");

                Console.WriteLine("ID" + "     " + "TYPE" + "     " + "BRAND" + "         " + "NAME" + "             " + "PRICE"+"      "+"AMMOUNT");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                int i;
                for (i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].productId + "     " + list[i].productType + "    " + list[i].productBrand + "         " + list[i].productName + "            " + list[i].price + "      " +list[i].ProductAmmount) ;
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                }
            
        }



    }
}
