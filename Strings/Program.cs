using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringIntro();

            string sentence = "My Name İs Erdal Bars";
            var result = sentence.Length;                                   //kaç karekterden oluştuğunu söyler
            var result2 = sentence.Clone();                              // stringi klonlar
            bool result3 = sentence.EndsWith("s");                            //Son karakteri kontrol eder.
            bool result4 = sentence.StartsWith("M");                         //İlk karakteri kontol eder.
            var result5 = sentence.IndexOf("name");                      //verilen karakterin kaçıncı sırada olduğunu söyler
            var result6 = sentence.LastIndexOf("a");                    //Sondan kaçıncı karakter olduğunu söyler
            var result7 = sentence.Insert(0, "Hello,"); //Belirtilen indexe kelime ekler
            var result8 = sentence.Substring(3);                    //stringin belirlediğimiz indexinden itibaren yazdırır.
            var result9 = sentence.ToLower();                      //Bütün Karekterleri küçüğe çevirir
            var result10 = sentence.ToUpper();                    //Bütün karakterleri Büyüğe çevir
            var result11 = sentence.Replace(" ", "--"); // Metin içerisinde istediğimiz kelimeyi değiştirmeye yarar
            var result12 = sentence.Remove(2, 5); //Belirttiğimiz indexten itibaren silmeye yarar(virgülden sonrası kaç adet silmek istediğiniz)

            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void StringIntro()
        {
            string city = "Ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + " " + city2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
