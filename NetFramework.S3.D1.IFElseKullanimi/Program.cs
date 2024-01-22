using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D1.IFElseKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanım
            if (true)
            {
                // bu işlemleri yap
            }
            else
            {
                // bu işlemleri yap
            }
            #endregion

            #region If Else Merhaba 
            int sayi1 = 50;
            int sayi2 = 15;

            //bool sonuc = sayi1 < sayi2;
            //if(sonuc)
            //{
            //    Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür.");
            //}

            //if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür.");
            //}

            if (sayi1 < sayi2) Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür.");
            else Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür.");

            if (sayi1 < sayi2)
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür.");


            #endregion

        }
    }
}
