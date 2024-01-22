using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D2.IFElseOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "";
            string sifre = "";

            Console.Write("Lütfen kullanıcı adınızı giriniz : ");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Lütfen şifrenizi giriniz : ");
            sifre = Console.ReadLine();

            if(kullaniciAdi=="Demo" && sifre == "1234")
            {
                Console.WriteLine("Giriş yaptınız tebrikler ");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı girişi");
            }
        }
    }
}
