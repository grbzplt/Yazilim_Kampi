using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
