using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;

            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public void printAll()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }



        public int Length
        { // Works for Printing the number of items (elements) in items array.

            get { return items.Length; }
        }

        public T[] Items
        { //  Works for Listing the items (elements) in items array.

            get { return items; }
        }


    }
}
