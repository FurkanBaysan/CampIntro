using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course firstCourse = new Course();
            firstCourse.courseName = "C# and Angular Bootcamp";
            firstCourse.completionRate = 35.0;
            firstCourse.instructorName = "Engin Demirog";

            Course secondCourse = new Course();
            secondCourse.courseName = "Java and React Bootcamp";
            secondCourse.instructorName = "Furkan Baysan";
            secondCourse.completionRate = 65.0;


            Console.WriteLine("course name:" + firstCourse.courseName + " " + "instructor name:" + " " + firstCourse.instructorName + " " + "completion rate: " + firstCourse.completionRate);
            Console.WriteLine("course name:" + secondCourse.courseName + " " + "instructor name:" + " " + secondCourse.instructorName + " " + "completion rate: " + secondCourse.completionRate);


            Console.WriteLine("We printed the object's attributes one by one");
            Console.WriteLine("---------------------");

            Console.WriteLine("Let's print the attributes of Objects by Object Array in order to constitute a dynamic system:");
            Console.WriteLine("----------------------");

            //Course[] courses = { firstCourse, secondCourse };

            Course[] courses = new Course[] {

               firstCourse,secondCourse
        };

            foreach (Course course in courses)
            {
                Console.WriteLine(course.courseName + "\n" + course.instructorName + "\n" + course.completionRate);
                //real life- some kind of html code which shows the courses with a GUI.


            }
        }
        class Course
        {
            public string courseName;
            public string instructorName;
            public double completionRate;
        }
    }
}
