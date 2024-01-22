using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D3.IFElseQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isimSoyisim = string.Empty;

            string kullaniciGelen1 = string.Empty;
            string kullaniciGelen2 = string.Empty;
            string kullaniciGelen3 = string.Empty;

            int not1, not2, not3 = 0;

            double ortalama = 0;

            Console.WriteLine("Lütfen ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");

            Console.Write("İsim Soyisim : ");
            isimSoyisim = Console.ReadLine();

            Console.Write("1. Not değerini giriniz : ");
            kullaniciGelen1 = Console.ReadLine();

            Console.Write("2. Not değerini giriniz : ");
            kullaniciGelen2 = Console.ReadLine();

            Console.Write("3. Not değerini giriniz : ");
            kullaniciGelen3 = Console.ReadLine();

            not1 = int.Parse(kullaniciGelen1);
            not2 = int.Parse(kullaniciGelen2);
            not3 = int.Parse(kullaniciGelen3);

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 45)
            {
                Console.WriteLine("Merhaba {0}", isimSoyisim);
                Console.WriteLine("Not ortalamanız {0} değeri ile geçtiniz", ortalama);
            }
            else Console.WriteLine("Kaldınız");
        }
    }
}
