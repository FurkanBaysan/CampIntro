using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Furkan");
            names.printAll();

            Console.WriteLine(names.Length); // this Length is our Length in MyList Class.

            names.Add("Selenay");
            names.printAll();

            Console.WriteLine(names.Length); // this Length is our Length in MyList Class.


            // A way to Listing items (elements) in items array.
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }






        }
    }
}
