using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Bişey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
