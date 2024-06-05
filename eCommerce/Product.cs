using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            if (productName == "" | productName == null)
            {
                throw new Exception("Product Name is null");
            }
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            
            if (amount > 0)
            {
                Stock += amount;
            }
            else
            {
                throw new Exception("Amount is less than 0");
            }

            

        }

        public void DecreaseStock(int amount)
        {
            if (amount > 0)
            {
                Stock -= amount;
            }
            else
            {
                throw new Exception("Amount is less than 0");
            }
            

        }

        public string ValidateProduct()
        {
            string message = "Valid Product.";

            if (ProductID < 7 || ProductID > 70000)
            {
                message = "Product ID is Invalid.";
            }
            else if (Price < 7 || Price > 7000)
            {
                message = "Price is Invalid.";
            }
            else if (Stock < 7 || Stock > 700000)
            {
                message = "Stock is Invalid.";
            }
            return message;
        }
    }
}
