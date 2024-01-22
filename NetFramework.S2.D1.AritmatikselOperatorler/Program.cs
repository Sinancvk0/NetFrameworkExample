using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D1.AritmatikselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aritmatiksel operatör 
            /*
             * + Toplama 
             * - Çıkartma 
             * / Bölme 
             * * Çarpma 
             * % Mod alma işlemlerinde 
             * 10%3 = 1
             * -- Çıkartma işleminde kullanacağımız bir operatör 
             * ++ Toplama işlemnde kullanacağımız bir opertör 
             * 
             */

            // + Toplama Operatörü 
            #region Operatorler - Toplama ( Tanım ) 
            int toplamOperatoruSayi1 = 10;
            int toplamOperatoruSayi2 = 15;
            int toplamOperatoruToplam = toplamOperatoruSayi1 + toplamOperatoruSayi2;
            Console.WriteLine("Toplam : " + toplamOperatoruToplam);
            #endregion
            #region Operatorler - Toplama - Ödev 
            //Console.WriteLine("Ekran üzerinden girilen iki farklı sayıyı toplayan bir uygulama yazınız ... ");

            //string kullaniciGelenDeger1 = string.Empty;
            //string kullaniciGelenDeger2 = string.Empty;

            //int odevSayi1 = 0;
            //int odevSayi2 = 0;

            //int odevToplam = 0;

            //Console.WriteLine("1. sayıyı giriniz");
            //kullaniciGelenDeger1 = Console.ReadLine();

            //Console.WriteLine("2. sayıyı giriniz");
            //kullaniciGelenDeger2 = Console.ReadLine();

            //odevSayi1 = int.Parse(kullaniciGelenDeger1);
            //odevSayi2 = int.Parse(kullaniciGelenDeger2);

            //odevToplam = odevSayi1 + odevSayi2;

            //Console.WriteLine("Toplam değer :" + odevToplam);
            #endregion

            #region Operatorler - Çıkartma ( Tanım ) 
            int cikartOperatoruSayi1 = 30;
            int cikartOperatoruSayi2 = 10;
            int cikartOperatoruSonuc = cikartOperatoruSayi1 - cikartOperatoruSayi2;
            Console.WriteLine("Çıkartma işlemi sonucu : {0}", cikartOperatoruSonuc);
            #endregion
            #region Toplama işleminde yapmış olduğumuz gibi bir uygulamayı çıkartma işleminde yapalım. 
            #endregion

            #region Operatorler - Bolme ( Tanım ) 
            int bolmeOperatoruSayi1 = 30;
            int bolmeOperatoruSayi2 = 2;
            int bolmeOperatoruSonuc = bolmeOperatoruSayi1 / bolmeOperatoruSayi2;
            Console.WriteLine("Bölme işlemi sonucu : {0}", bolmeOperatoruSonuc);
            #endregion

            #region Operatorler - Çarpma ( Tanım ) 
            int carpmaOperatoruSayi1 = 10;
            int carpmaOperatoruSayi2 = 2;
            int carpmaOperatoruSonuc = carpmaOperatoruSayi1 * carpmaOperatoruSayi2;
            Console.WriteLine("Çarpma işlemi sonucu {0}", carpmaOperatoruSonuc);
            #endregion

            #region Opratorler - Mod ( Tanım ) 
            int modOperatoruSayi1 = 10;
            int modOperatoruSayi2 = 3;
            int modOperatoruSonuc = modOperatoruSayi1 % modOperatoruSayi2;
            Console.WriteLine("Mod işlemi sonuc {0}", modOperatoruSonuc);
            #endregion

            #region -- ++ Operatorunun incelenmesi 
            int aritmatikselSayi = 40;
            aritmatikselSayi++; // aritmatiselSayi = aritmatikselSayi + 1;
            aritmatikselSayi--;
            aritmatikselSayi += 5;
            #endregion











        }
    }
}
