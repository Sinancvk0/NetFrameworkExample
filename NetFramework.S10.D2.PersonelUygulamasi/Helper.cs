using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public static class Helper
    {
        // Static olarak işaretlenmiş classlar örneklenemez..
        //  Helper H1 = new Helper();
        /*
            public void Test()
        {

        }

            Static olan class lar içerisinde standart metotlar kullanıamaz. ( static olmayan metotlar ) 

            public string Tanim { get; set; }

            Static olan class lar içerisinde static olmayan field tanımları yapılamaz. 
         */

        //public Helper()
        //{
        // Her nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır. 
        //}

        static Helper()
        {
            // Uygulama içerisinde istenildiği kadar çağrılsınlar sadece ilk çağrılmada çalışırlar...
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            // Email gönderme işlemleri devam edecek ... 
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }

        


    }
}
