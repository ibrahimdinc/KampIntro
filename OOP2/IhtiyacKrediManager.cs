using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Bişey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
