using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi" + ":" + musteri.Id + "  " + musteri.Tckn + "  " + musteri.Name + "  " + musteri.SurName + "  " + musteri.Job + "  " + musteri.Gender);

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi" + ": " + musteri.Id + "  " + musteri.Tckn + "  " + musteri.Name + "  " + musteri.SurName + "  " + musteri.Job + "  " + musteri.Gender);

        }
    }
}