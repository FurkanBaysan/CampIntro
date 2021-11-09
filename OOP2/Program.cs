using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            BireyselMusteri firstCustomer = new BireyselMusteri();
            TuzelMusteri secondCustomer = new TuzelMusteri();

            firstCustomer.id = 1;
            firstCustomer.customerNo = "456";
            firstCustomer.tcNo = "1234";
            firstCustomer.customerName = "Furkan";
            firstCustomer.customerSurname = "Baysan";

            secondCustomer.id = 2;
            secondCustomer.customerNo = "789";
            secondCustomer.taxNo = "1234500000"; // taxNo should be 10 digit.
            secondCustomer.companyName = "Sabancı Holding";

            Console.WriteLine("id:" + firstCustomer.id + "\n" + "Customer No:" + firstCustomer.customerNo + "\n" + "Tc No:" + firstCustomer.tcNo + "\n" +
                "Customer Name and Surname:" + firstCustomer.customerName + " " + firstCustomer.customerSurname);

            Console.WriteLine("-------------");

            Console.WriteLine("id:" + secondCustomer.id + "\n" + "Customer No:" + secondCustomer.customerNo + "\n" + "Tax No:" + secondCustomer.taxNo + "\n" +
                "Company Name:" + secondCustomer.companyName);

            // Introduction to Polymorphism
            Musteri thirdCustomer = new BireyselMusteri();
            Musteri fourthCustomer = new TuzelMusteri();



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(firstCustomer);
            musteriManager.Add(secondCustomer);
            musteriManager.Add(thirdCustomer);
            musteriManager.Add(fourthCustomer);

        }
    }
}























