using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product firstProduct = new Product();

            //First way to reach and assign values to firstProduct Object attributes.

            firstProduct.id = 1;
            firstProduct.categoryId = 2; // Eg. 2 -> Represents Elektronik Category.
            firstProduct.productName = "Huawei Free Buds Pro, Earphone";
            firstProduct.unitPrice = 1500;
            firstProduct.unitsInStock = 3;

            // Second way to reach and assign values to secondProduct Object attributes. 5-> represents Kitap ve Kırtasiye Category.
            Product secondProduct = new Product { id = 2, categoryId = 5, unitsInStock = 5, productName = "Operating System Concepts, Book", unitPrice = 35 };

            //third way to reach and assign values to thirdProduct Object attributes. - Constructor
            Product thirdProduct = new Product(3, 7, "Zara Men Black,Sweatshirt", 200, 100);


            Product[] products = new Product[]
            {
                firstProduct,secondProduct,thirdProduct
            };


            foreach (Product product in products)
            {
                Console.WriteLine("Product id:" + product.id + "\n" + "Product Category Id:" + product.categoryId + "\n" + "Product Name:" + product.productName + "\n" + "product Price:" + product.unitPrice + "\n" + "Product Stock Number:" + product.unitsInStock);
                Console.WriteLine("------");
            }

            Console.WriteLine("-----------------------");


            ProductManager productManager = new ProductManager();
            productManager.Add(firstProduct);
            productManager.Update(secondProduct);
            productManager.Delete(thirdProduct);
        }
    }
}
