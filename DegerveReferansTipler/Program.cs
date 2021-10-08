using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //deep-copy
            int number1 = 10;
            int number2 = 30;
            number1 = number2; // number2'nun tuttuğu değeri number1'a ata.
            number1 = 65;
            Console.WriteLine(number1);



            // shallow-copy
            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2; // numbers2'nin point ettiği array'i numbers1'de point etsin.
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
        }
    }
}
