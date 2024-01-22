using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D5.doWhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Odev 1 : Kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun. Kullanıcı adı : Demo Şifre : Demo eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.cw

            //string kullaniciAdi = string.Empty;
            //string sifre = string.Empty;
            //int sayac = 0;

            //do
            //{
            //    // sayaç ile kontrol etmemiz önemli bunun nedeni do while içerisinde herhangi bir if koşulu ile şartlarımızı kontrol etmedik while ( şart ) blogu içerisinde kontrollerimizi yaptığımız için değerin hatalı veya doğru olduğunu sayac adındaki bu değişken üzerinden kontrol ettik.
            //    if (sayac > 0)
            //        Console.WriteLine("Kullanıcı adı veya şifre değerlerinizden birisi hatalı");

            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    kullaniciAdi = Console.ReadLine();

            //    Console.WriteLine("Şifre girişi yapınız");
            //    sifre = Console.ReadLine();

            //    sayac++;

            //} while (kullaniciAdi.ToLower() != "demo" || sifre.ToLower() != "demo");

            //Console.WriteLine("Başarılı kullanıcı girişi");

            // Demo - demo - DeMo - 


            #endregion

            #region Odev 2 : Kullanıcıdan 1 ile X arasında bir sayı girmesini isteyin. Daha sonra sistem kullanıcının girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın. Daha sonra kullanıcu sistemin tahmin etmiş olduğu sayıyı bulmaya çalışssın. Bulamaz ise yeniden yeniden sorsun. Ne zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin. 

            int odev2tahmin = 0;
            int odev2uretilenSayi = 0;
            int odev2sayac = 0;

            Console.WriteLine("Tahmin oyunu için en yüksek değeri giriniz");
            int odev2kullaniciMaxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            odev2uretilenSayi =  rnd.Next(1, odev2kullaniciMaxValue);

            do
            {
                odev2sayac++;
                Console.WriteLine("{0} hakkınız üretilen sayıyı tahmin ediniz", odev2sayac);
                odev2tahmin = int.Parse(Console.ReadLine());


            } while (odev2tahmin != odev2uretilenSayi);

            Console.WriteLine("{0}. kere denediniz Sayıyı tahmin ettiniz", odev2sayac);



            #endregion
        }
    }
}
