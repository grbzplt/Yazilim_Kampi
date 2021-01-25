using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
