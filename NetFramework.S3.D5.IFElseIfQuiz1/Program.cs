using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D5.IFElseIfQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciGelenDeger1, kullaniciGelenDeger2,kullaniciGelenSecim = string.Empty;
            int sayi1, sayi2, sonuc = 0;

            Console.Write("Sayı 1 değerini giriniz : ");
            kullaniciGelenDeger1 = Console.ReadLine();

            Console.Write("Sayı 2 değerini giriniz : ");
            kullaniciGelenDeger2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İşleminizi Seçiniz");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiminiz : ");
            kullaniciGelenSecim = Console.ReadLine();

            sayi1 = int.Parse(kullaniciGelenDeger1);
            sayi2 = int.Parse(kullaniciGelenDeger2);

            if(kullaniciGelenSecim == "1")
            {
                sonuc = sayi1 + sayi2;
            }
            else if(kullaniciGelenSecim == "2")
            {
                sonuc = sayi1 - sayi2;
            }
            else if(kullaniciGelenSecim == "3")
            {
                sonuc = sayi1 * sayi2;
            }
            else if(kullaniciGelenSecim == "4")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Aralık dışında değer girişi yaptınız");
            }

            if (sonuc != 0)
                Console.WriteLine("İşleminizin sonucu {0}", sonuc);
        }
    }
}
