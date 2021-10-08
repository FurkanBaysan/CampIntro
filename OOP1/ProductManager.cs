using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("product name:" + " " + product.productName + " -> " + "added to database");
        }

        public void Update(Product product)
        {
            Console.WriteLine("product name:" + " " + product.productName + " -> " + "updated in database");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("product name:" + " " + product.productName + " -> " + "deleted from database");
        }
    }
}
