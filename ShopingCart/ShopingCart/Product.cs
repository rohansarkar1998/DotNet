using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart
{
    class Product
    {
        public int productId;
        public string productType;
        public string productBrand;
        public string productName;
        public int price;
        public int productAmmount;
        
        public Product()
        {

        }
        public Product(int productId, string productType, string productBrand,string productName, int price, int productAmmount)
        {
            this.productId = productId;
            this.productType = productType;
            this.productName = productName;
            this.productBrand = productBrand;
            this.price = price;
            this.productAmmount = productAmmount;
        }



        public int ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }

        public string ProductType
        {
            get
            {
                return productType;
            }

            set
            {
                productType = value;
            }
        }
       

        public string ProductBrand
        {
            get
            {
                return productBrand;
            }

            set
            {
                productBrand = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int ProductAmmount
        {
            get
            {
                return productAmmount;
            }

            set
            {
                productAmmount = value;
            }
        }

    }
}
