﻿using System;

namespace KampIntro
{
    class Program
    {
        

    
        static void Main(string[] args)
        {
             string kategoriEtiketi = "Kategori";
             int ogrenciSayisi = 32000;
             double faizOrani = 1.45;
             bool sistemeGirisYapmisMi = true;
             double dolarDun = 7.35;
             double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
                {
                    Console.WriteLine("Azalış Butonu");
                }
            else if (dolarDun<dolarBugun)
                {
                    Console.WriteLine("Artış Butonu");
                }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            }
        }
    }
}
