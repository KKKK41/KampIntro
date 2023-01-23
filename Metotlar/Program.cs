using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 67;
            kurs1.KursEgitmeni = "KK";

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "java";
            kurs2.IzlenmeOrani = 64;
            kurs2.KursEgitmeni = "KT";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
                Console.WriteLine(item.IzlenmeOrani);
                Console.WriteLine(item.KursEgitmeni);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------------------Metotlar--------------");
            //instance 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public int IzlenmeOrani { get; set; }

        public string KursEgitmeni { get; set; }

    }
}
