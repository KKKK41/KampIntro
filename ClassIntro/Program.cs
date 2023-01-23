using System;

namespace ClassIntro
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

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "python";
            kurs3.IzlenmeOrani = 74;
            kurs3.KursEgitmeni = "KV";


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs adı:" + kurs.KursAdi);
                Console.WriteLine("İzlenme oranı:" + kurs.IzlenmeOrani);
                Console.WriteLine("Eğitmenin Adı:" + kurs.KursEgitmeni);
                Console.WriteLine("----------------------");
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
