using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D2.KarsilastirmaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * < : Küçüktür 
             * > : Büyüktür 
             * <= : Küçük eşittir. 
             * >= : Büyük eşittir. 
             * == : eşittir. 
             * != : eşit değildir. 
             * is : tür dönüşümlerinde kullandığımız operatör 
             * as : tür dönüşümlerinde kullandığımız operatör
             */
            int Sayi1 = 10;
            int Sayi2 = 10;

            #region Küçüktür Operatörü Tanım 
            bool KucukOpertorSonuc = Sayi1 < Sayi2;
            Console.WriteLine(KucukOpertorSonuc);
            #endregion

            #region Buyuktur operatöru Tanım 
            bool BuyukOperatorSonuc = Sayi1 > Sayi2;
            Console.WriteLine(BuyukOperatorSonuc);
            #endregion

            #region Kucuk Esittir Operatoru Tanım 
            bool KucukEsittirSonuc = Sayi1 <= Sayi2;
            Console.WriteLine(KucukEsittirSonuc);
            #endregion

            #region Buyuk Esittir Operatörü Tanım 
            bool BuyukEsittirSonuc = Sayi1 >= Sayi2;
            Console.WriteLine(BuyukOperatorSonuc);
            #endregion

            #region == != Operatorleri Tanım 
            bool esittirOperatorSonuc = Sayi1 == Sayi2;
            bool esitDegildirOperatorSonuc = Sayi1 != Sayi2;

            #endregion

            #region is - as operatörleri Tanım 
            object O1 = "Cengiz";
            // int sayi1 = (int)O1;

            bool veriTipiKontrol = O1 is int;
            object O2 = "Cengiz Atilla";
            string isim = O2 as string;


            Console.WriteLine("");
            #endregion
        }
    }
}
