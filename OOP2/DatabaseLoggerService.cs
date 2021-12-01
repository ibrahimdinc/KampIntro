using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Logla()
        {
            Console.WriteLine("Veri Tabanına Loglandı.");
        }
    }
}
