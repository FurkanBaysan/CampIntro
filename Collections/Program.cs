using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Furkan", "Anil", "Velo", "Zeynep" };


            // Printing the data's in the array
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("---------");

            Console.WriteLine("Random Access Case:");

            names[3] = "Selenay";
            Console.WriteLine(names[3]);

            // Assume that we want add a new element to array and print it -> 

            //names[4] = "Kaya";
            //Console.WriteLine(names[4]);

            //Bunu yaptığımız anda -> System.IndexOutOfRangeException hatası alırız.
            // Sebebi düz,normal Array yapılarında Dynamic Memory Allocation'ın vuku bulmaması.


            Console.WriteLine("---------");
            Console.WriteLine("Lack of Dynamic Memory Allocation Case:");


            names = new string[5];
            names[4] = "Kaan";
            Console.WriteLine(names[4]);

            Console.WriteLine("----------------------------");
            Console.WriteLine("In presence of  Dynamic Memory Allocation:");


            List<string> names2 = new List<string> { "Furkan", "Anil", "Velo", "Selenay" };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            // Assume that we want add a new element to array and print it -> 

            names2.Add("Burak");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            //Bu sefer patlamadık, çünkü dynamic memory allocation vuku buldu.


















        }
    }
}
