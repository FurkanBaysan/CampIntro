using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string course1 = "Yazilim Gelistirici Yetistirme Kampi C# ve Angular";
            //string course2 = "Programlamaya Giris Kursu";
            //string course3 = "Yazilim Gelistirici Yetistirme Kampi Java ve React";

            string[] courses = new string[] { "Yazilim Gelistirici Yetistirme Kampi C# ve Angular",
                "Programlamaya Giris Kursu",
                "Yazilim Gelistirici Yetistirme Kampi Java ve React" };

            bringMyCourses(courses);
            Console.WriteLine("-----------");


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("End of for.");
            Console.WriteLine("-------------");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("End of Page-Footer");



        }
        public static void bringMyCourses(string[] courses)
        {
            string[] myCourses = new string[]
            {
                "OOP with Java","Introduction to Programming with C++"
            };
            courses = myCourses;

            foreach (string course in myCourses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("End of my Courses.");
        }
    }
}
