using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D5.ConsoleKomutlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger = string.Empty;

            // Kullanıcıya mesaj göstermek ... 

            Console.Write("Mesaj 1"); // metni ekrana yazar imleç yanında bekler. 
            Console.WriteLine("Mesaj 2"); // metni ekrana yazar imleç bir alt satırda bekler. 

            // Ekranda bulunan tüm datayı silmek için 

            Console.Clear();

            // Temel bir ihtiyacımız olan kullanıcıdan değer alma .. 

            Console.Write("Lütfen adınızı giriniz :");
            kullanicidanGelenDeger = Console.ReadLine();

            // Elimizde olan değişken veya değişkenleri kullanarak kullanıcıya bir mesaj göstermenin birden fazla yöntemi bulunmaktadır. 

            // 1. Yöntem

            string mesaj = "Girmiş olduğunuz isim değeri " + kullanicidanGelenDeger;
            Console.WriteLine(mesaj);

            Console.Clear();

            // 2. Yontem 
            mesaj = "";
            mesaj = string.Format("Girmiş olduğunuz isim değeri {0}", kullanicidanGelenDeger);

            // 3. Yontem 
            Console.Clear();
            Console.WriteLine("Girmiş olduğunuz isim değeri {0}", kullanicidanGelenDeger);

            Console.Clear();

            Console.Write("Lütfen 1 - 10 arasında bir değeri giriniz");
            string gelenDeger = Console.ReadLine();

            int sayi1 = int.Parse(gelenDeger);
            int sayi2 = Convert.ToInt32(gelenDeger);
            // parse ile convert arasındaki fark.
            int toplam = sayi1 + 15;
            Console.WriteLine("Toplam değer : {0}", toplam);

            


            Console.ReadLine();
        }
    }
}
