using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;


            // Bilinçli Tür Dönüşü 

            int sayi2 = 125;

            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            // Bilinçsiz Tür Dönüşümü ; 

            double sayi3 = 10;

            sayi3 = sayi2;

            Console.WriteLine(sayi3);

            // checked - uncheced 

            unchecked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2;
            }

            //checked
            //{
            //    sayi2 = 512;
            //    sayi1 = (byte)sayi2;
            //}

            // object : veri tipi tüm .net veritiplerinin atasıdır. 
            object temelTip = sayi2;
            temelTip = sayi3;
            temelTip = new
            {
                marka = "Opel",
                model = "Corsa",
            };

            // Boxing işlemi ... 

            temelTip = sayi2; // Boxing işlemi. 
            sayi2 = (int)temelTip; // unboxing işlemi.

            Console.Write("");




        }
    }
}
