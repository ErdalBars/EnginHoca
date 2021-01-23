using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Kredi Onaylandı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
            Console.WriteLine();
        }
    }
}
