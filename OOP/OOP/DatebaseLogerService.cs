using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DatebaseLogerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Log Kaydedildi.");
        }
    }
}
