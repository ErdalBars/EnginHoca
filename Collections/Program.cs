using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin", "Murat","Kerem","Halil"};
            {
                Console.WriteLine(isimler[0]);
                Console.WriteLine(isimler[1]);
                Console.WriteLine(isimler[2]);
                Console.WriteLine(isimler[3]);
                /*Array de sonradan eleman ekleyemezsin o yüzden 
                 Array yerine List Kullanmalısın */

                List<string> isimler2 = new List<string> {"Erdal", "Bilal", "Sevinç","Naim"};

                Console.WriteLine(isimler[0]);
                Console.WriteLine(isimler[1]);
                Console.WriteLine(isimler[2]);
                Console.WriteLine(isimler[3]);
                isimler2.Add("İlker");
                Console.WriteLine(isimler[4]);
            }
        }
    }
}
