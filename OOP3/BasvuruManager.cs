using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Başvuru işlemlerini(eylemlerini,operasyonlarını) yöneten nesne.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {

            //Dependency Injection- Esasen Method Injection yapıyoruz.
            //-> Yani bu methodun kullanacağı KrediManager'ın ne olucağını (yani Kredi Turunun ne olucağını)
            //ve Hangi Loglayacığa (istediğimiz herhangi biri) veya List şeklinde parametre geçirirsek birden fazla loglayıcıya
            //enjekte ediyoruz. Bir de Constructor Injection var.


            // Başvuran bilgilerini değerlendirme.. gibi işlemler yapılır.. Birsürü kod yazarız burda..
            // Bu algoritmanın içinde biz de -> Krediyi Hesaplayalım.
            krediManager.KrediHesapla();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }



        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.KrediHesapla();
            }
        }
    }
}
