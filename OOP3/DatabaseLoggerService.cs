using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı Loglandı");
        }
    }
}
