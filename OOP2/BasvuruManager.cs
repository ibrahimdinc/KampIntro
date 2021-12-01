using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini  değerlendirme

            krediManager.Hesapla();
            loggerService.Logla();

        }
        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
