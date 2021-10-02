using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat yourself -DRY ,Clean Code, Best Practice ( Doğru Uygulama )

            Product firstProduct = new Product();
            Product secondProduct = new Product();



            firstProduct.id = 1;
            firstProduct.brand = "Huawei";
            firstProduct.productName = "Matebook X Pro";
            firstProduct.price = 10000;
            firstProduct.color = "green";

            secondProduct.id = 2;
            secondProduct.brand = "Samsung";
            secondProduct.productName = "Smart TV";
            secondProduct.price = 4000;
            secondProduct.color = "black";


            Product[] products = new Product[]
            {
                firstProduct,secondProduct
            };

            foreach (Product product in products)
            {
                Console.WriteLine("product id:" + product.id + "\n" + "product brand:" + product.brand + "\n" + "product name:" + product.productName + "\n" + "product price:" + product.price + "\n" +
                    "product color:" + product.color);
                Console.WriteLine("---------");
            }

            Console.WriteLine("--------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.addtoSepet(firstProduct);
            sepetManager.addtoSepet(secondProduct);
        }
    }
}
