using System;

namespace classIntroSon
{
    class Program
    {
        static void Main(string[] args)
        {



            string KullaniciAdi = "Meyra";
            int yas = 27;

            //kurs adında bi kendi veri tipimizi yazıyoruz, int gibi str gibi..

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin D.";
            kurs1.izlenmeOrani = 33;


            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C#";
            kurs2.Egitmen = "Kerem D.";
            kurs2.izlenmeOrani = 34;


            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C#";
            kurs3.Egitmen = "Berkay D.";
            kurs3.izlenmeOrani = 30;

        }
        Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach ( var kurs in kurslar)
	{
            Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);
	}

            //bir kurs objesi oluşturuyorum; kursun üç tane özelliği var, ad,eğitmen,izlenme oranı
        class Kurs
        {
            public string kursAdi { get; set; }
            public string Egitmen { get; set; }
            public int izlenmeOrani { get; set; }
        }




    }
}

