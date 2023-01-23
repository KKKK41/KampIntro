using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği yazdığımız ifadenin veri türünü yazmalıyız.
            //don't repeat yourself
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; //ondalıklı
            bool sistemeGirisYapmısMı = true; //ya da false
            double dolarDun = 7.35;
            double dolarBugun = 18.95;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("artan ok");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalan ok");
            }
            else
            {
                Console.WriteLine("eşit");
            }


            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("kullanıcı ayarları");
            }
        }
    }
}