using System;
using System.Security.Cryptography.X509Certificates;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {       // Erdal Bars
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNumber = "12345";
            musteri1.FirstName = "Erdal";
            musteri1.LastName = "Bars";
            musteri1.TCKN = "1316546465";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "646546";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "456435432321";


            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            C
        }
    }
}
