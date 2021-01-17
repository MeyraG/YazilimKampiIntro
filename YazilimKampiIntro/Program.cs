using System;

namespace YazilimKampiIntro
{
    class Program
    {
        static void Main(string[] args)



        {

            int ogrensiSayisi = 32000;
            double devamOrani = 0.08;
            bool sistemeGirisYapildiMi = true;

            double dersDevam = 1.5;
            double dersDevam2 = 2.0;

            if (dersDevam > dersDevam2)
            {
                Console.WriteLine("Derslere katıl");

            }

            else
            {
                Console.WriteLine("Böyle devam");

            }

            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }


            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double boyOrtalaması = 1.6;
            bool girisYapildiMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (girisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
