using System;

namespace classFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = " Meyra ";
            int yas = 27;
            
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin D.";
            kurs1.izlenmeOrani = 65;




            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C";
            kurs2.Egitmen = "Erdinç D.";
            kurs2.izlenmeOrani = 66;




            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C++";
            kurs3.Egitmen = "Ergin D.";
            kurs3.izlenmeOrani = 63;


            //Console.WriteLine(kurs1.kursAdi +" "+ kurs1.Egitmen +"izlenme Oranı:" +kurs1.izlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.Egitmen);

            }
        }
    }

    class Kurs 
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
