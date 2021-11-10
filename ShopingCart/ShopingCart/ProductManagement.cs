using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart
{
    class ProductManagement
    {
        static int totalBill = 0;
        List<Product> list = new List<Product>();
        List<Product> orderList = new List<Product>();
        ProductDeatels p = new ProductDeatels();
        
        public void creatList()
        {
            list = p.productList();
        }

        public void placeOrder(Dictionary<int, int> order)
        {
            int id;
            int number;
            foreach (KeyValuePair<int, int> d in order)
            {
                id = d.Key;
                number = d.Value;

                int i;


                for (i = 0; i < list.Count; i++)
                {
                    if (list[i].productId == id)
                    {

                        if (list[i].productAmmount >= number)
                        {
                            int price = number * list[i].price;

                            Product product = new Product();
                            product.productId = list[i].productId;
                            product.productType = list[i].productType;
                            product.productBrand = list[i].productBrand;
                            product.productName = list[i].productName;
                            product.productAmmount = number;
                            product.price = price;
                            orderList.Add(product);


                            int ammountLeft = list[i].productAmmount - number;
                            list[i].productAmmount = ammountLeft;


                            totalBill = totalBill + price;


                        }
                        else
                        {
                            Console.WriteLine("SORRY !!!!    ONLY  " + list[i].productAmmount + " LEFT");
                        }

                    }
                }

            }
        }

        public void generateBill()
        {
            Console.WriteLine("ID" + "     " + "TYPE" + "     " + "BRAND" + "         " + "NAME" + "          " + "NUMBER" + "    " + "PRICE");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            int j = 0;

            for (j = 0; j < orderList.Count; j++)
            {
                Console.WriteLine(orderList[j].productId + "     " + orderList[j].productType + "    " + orderList[j].productBrand + "         " + orderList[j].productName + "            " + orderList[j].productAmmount + "           " + orderList[j].price);
                Console.WriteLine("----------------------------------------------------------");
            }

            Console.WriteLine("TOTAL AMMOUNT  " + totalBill);


        }



        public void updateStock(Dictionary<int, int> update)
        {
            int id;
            int number;
            foreach (KeyValuePair<int, int> d in update)
            {
                id = d.Key;
                number = d.Value;
                int i;
                for (i = 0; i < list.Count; i++)
                {
                    
                    if (list[i].productId == id)
                    {
                        list[i].productAmmount = list[i].productAmmount + number;

                    }
                }
            }

        }

        public void addNewProduct(Product p)
        {
            p.productId = list[list.Count - 1].productId + 1;
            list.Add(p);
        }



        public void removeStock(int id)
        {
            
            int i;
            Console.WriteLine(id);
            for(i=0;i<list.Count;i++)
            {
                if(list[i].productId == id)
                {

                    Product p1 = new Product();
                    p1.productId = id;
                    p1.productType = list[i].productType;
                    p1.productBrand = list[i].productBrand;
                    p1.ProductName = list[i].productName;
                    p1.productAmmount = list[i].productAmmount;
                    p1.price = list[i].price;

                    int num = id - 1;
                    list.RemoveAt(num);
                }
            }
        }


        public void showStock()
        {
            Console.WriteLine("                               -----------------                   ");

            Console.WriteLine("ID" + "     " + "TYPE" + "     " + "BRAND" + "         " + "NAME" + "             " + "PRICE" + "      " + "AMMOUNT");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            int i;
            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].productId + "     " + list[i].productType + "    " + list[i].productBrand + "         " + list[i].productName + "            " + list[i].price + "      " + list[i].ProductAmmount);
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }


        }
    }
           
}
