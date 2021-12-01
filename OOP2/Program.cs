using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12234";
            musteri1.Adi = "ibrahim";
            musteri1.Soyadi = "dinç";
            musteri1.Id = 1;
            musteri1.TcNo = "1234567898";


            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama.Io";
            musteri2.VergiNo = "123456789";
            musteri2.MusteriNo = "12345";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1); // yani Musteri classı GercekMusteri ve Tuzel Musteri
                                           // claslarını inheritance ettiği için, Musteri isteyen bir 
                                           // metotda diğer 2 türü yazsak bile kabul eder.



            IKrediManager ihtiyacKredisi = new IhtiyacKrediManager();
            // yani IhtiyacKrediManager yazmak yerine IKredi Manager yazabiliyoruz. interface'ler de 
            // implement ettiği metodu içinde tutabiliyor
            //ihtiyacKredisi.Hesapla();

            IKrediManager tasitKredisi = new TasitKrediManager();
            //tasitKredisi.Hesapla();

            IKrediManager konutKredisi = new KonutKrediManager();
            //konutKredisi.Hesapla();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileBaseLoggerService = new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKredisi,dataBaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKredisi };
            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);


        }
    }
}
