using System;

namespace Donguler_Loops_
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);

            } 


            //bunlar array- dizi
            //köşeli parantezi koyduğum zaman bu bir array olur, birçok stringi tutar

            string[] kurslar = new string[] { "HTML", "Css", "Js", "Java" , "C#" };


            //ilerde string[] kurslar = kurslariGetir şeklinde bir array, kaynaktan gelir. Şu an biz elle yazdık.



            //i=i+2 dersek, i'yi ikişer arttır demek. i+=2 de aynı anlamda.

            for (int i = 0; i < kurslar.Length; i++) //length listedeki eleman sayısı kadar demek
            {
                Console.WriteLine(kurslar[i]);
                //bu bize kurslar stringinin i. elemanını yazdırır. Saymaya 0dan başlar

            }
            { 
                Console.WriteLine("xxx Sayfa Sonu xxx");


                //foreach dizilere uygulanır. tek tek dönmeye yarar. kurs yazdığımız yer alias,başka şey de diyebiliriz, item gibi,eleman gibi x gibi.
                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }


            }
        }
    }
}
