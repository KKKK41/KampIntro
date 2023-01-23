using System;

namespace ClassNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.name = "altıncocuk";
            urun1.page = 450;
            urun1.writer = "ben";

            Product urun2 = new Product();
            urun2.name = "altıncocuk";
            urun2.page = 450;
            urun2.writer = "ben";

            Product urun = new Product() {urun1, urun2 };
            

        }
    }

    class Product
    {
        public string name { get; set; }

        public int page { get; set; }

        public string writer { get; set; }
    }
}
