using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                Musteri musteri1 = new Musteri();

                musteri1.Id = 46546;
                musteri1.Tckn = 65463267986;
                musteri1.Name = "Erdal";
                musteri1.SurName = "Bars";
                musteri1.Job = "C# Developer";
                musteri1.Gender = "Male";

                Musteri musteri2 = new Musteri();

                musteri2.Id = 44545;
                musteri2.Tckn = 65461313654;
                musteri2.Name = "Ayşe";
                musteri2.SurName = "Eyşa";
                musteri2.Job = "java Developer";
                musteri2.Gender = "Female";

                Musteri musteri3 = new Musteri();

                musteri3.Id = 65432;
                musteri3.Tckn = 79865413213;
                musteri3.Name = "Ali";
                musteri3.SurName = "İla";
                musteri3.Job = "C++ Developer";
                musteri3.Gender = "Male";

                Musteri musteri4 = new Musteri();

                musteri4.Id = 46546;
                musteri4.Tckn = 65463267986;
                musteri4.Name = "Fatma";
                musteri4.SurName = "Amtaf";
                musteri4.Job = "C Developer";
                musteri4.Gender = "Female";

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

                foreach (var musteri in musteriler)
                {
                    Console.WriteLine("ID:" + musteri.Id);
                    Console.WriteLine("TCKN:" + musteri.Tckn);
                    Console.WriteLine("NAME:" + musteri.Name);
                    Console.WriteLine("SURNAME:" + musteri.SurName);
                    Console.WriteLine("JOB:" + musteri.Job);
                    Console.WriteLine("GENDER:" + musteri.Gender);
                    Console.WriteLine("***********************************");
                }

                MusteriManager musteriManager = new MusteriManager();

                musteriManager.Add(musteri3);
                Console.WriteLine("***********************************");
                musteriManager.Delete(musteri2);

            }
            Console.ReadLine();
        }
    }
}
