using System;

namespace Methods
{
    class Urun
    {
        static void Main(string[] args)
            
  
        {
            string urunAdi = "çilek";
            double fiyati = 15;
            string aciklama = "dağ çileği";

            string[] meyveler = new string[] {"çilek", "karpuz" };

            Urun[] urunler = new Urun[] { urun1, urun2 };

            Urun urun1 = new Urun();

            urun1.Adi = "çilek";
            urun1.Fiyati = 15;
            urun1.Aciklama = "dağ çileği";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            


            //in urunler;benim her elemanımı bir kez gezsin.- urun: alias.yani döneceği şey, item, x, i. 
            // baştaki Urun ise: veri tipim. var da yazsam olur
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");

            }



            Console.WriteLine("--------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();
        }
    }
}
//Don't Repeat Yourself-Clean Code-Best Practise