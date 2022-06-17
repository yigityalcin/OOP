using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //sen aslında bir ILoggerService alternatifisin demektir bu : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
