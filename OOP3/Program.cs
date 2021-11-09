using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object referer of Base Class or Interface (which act as a Base) can be able to point or hold the
            //subclass object's RAM location (reference). Object referer of Base Class or Interface (which act as a Base)
            //ALSO can be able to reach the overrided methods/actions that subclass objects override from itself.

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.KrediHesapla(); -> Learning Outcome 1
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.KrediHesapla();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.KrediHesapla();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager); -> Learning Outcome 2
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);


            Console.WriteLine("--Araba Kredisi Cekmek Icin Basvuru Yapan Musteriye Tavsiye Edilen Kredi Turleri Geri Odeme Planları--");
            List<IKrediManager> credits = new List<IKrediManager>
            {
                tasitKrediManager,ihtiyacKrediManager
            };
            basvuruManager.KrediOnBilgilendirmesiYap(credits); // -> Learning Outcome 3

            Console.WriteLine("---------------------");
            Console.WriteLine("-- Bir Musteri Krediye Basvuru Yaptığında, Geri Odeme Tutarının Hesaplanması ve " +
                "Musteriyi istenilen Loglama Alternatifi/Alternatiflerine Loglamak--");
            List<ILoggerService> loggerServices = new List<ILoggerService>
            {
                databaseLoggerService,smsLoggerService
            };
            basvuruManager.BasvuruYap(esnafKrediManager, loggerServices); // -> Learning Outcome 4









        }
    }
}
