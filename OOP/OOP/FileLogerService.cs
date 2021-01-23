using System;

namespace OOP
{
    class FileLogerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Log Kaydedildi.");
        }
    }
}
