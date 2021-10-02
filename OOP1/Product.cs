using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int id; //Primary Key
        public int categoryId; // Foreign Key
        public string productName;
        public double unitPrice;
        public int unitsInStock;

        // CRUD -> create,read,update,delete

        public Product()
        {

        }

        public Product(int id, int categoryId, string productName, double unitPrice, int unitsInStock)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
        }
    }
}
