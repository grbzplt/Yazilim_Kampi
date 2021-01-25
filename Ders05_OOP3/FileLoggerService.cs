using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
