using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryLabel = "Kategori";
            int studentNumber = 32000;
            double interestRate = 1.45;

            bool loggedintoSystemorNot = true;


            double yesterdayDolar = 7.35;
            double todayDolar = 7.15;

            if (yesterdayDolar > todayDolar)
            {
                Console.WriteLine("Decrease button");
            }
            else if (yesterdayDolar < todayDolar)
            {
                Console.WriteLine("Increase button");
            }
            else
            {
                Console.WriteLine("Equal button");
            }

            if (loggedintoSystemorNot == true)
            {
                Console.WriteLine("myCourses button");
                // <button>User Settings</button>
            }
            else
            {
                Console.WriteLine("Login button");
            }

            Console.WriteLine(categoryLabel);
        }
    }
}
