using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Volvo", "BMW", "Ford", "Mazda" }; 



            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (string kurs in kurslar)   //dizileri dolaşmak için.
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
