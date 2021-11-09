using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            //simüle ediyoruz. Gerçekte, Loglarken ne yapıyorsak o komutlar olucak burda.
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
