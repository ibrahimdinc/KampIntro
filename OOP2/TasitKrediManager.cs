using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Bişey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
