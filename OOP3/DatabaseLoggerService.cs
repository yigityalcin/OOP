using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService //sen aslında bir ILoggerService alternatifisin demektir bu (: ILoggerService)
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
