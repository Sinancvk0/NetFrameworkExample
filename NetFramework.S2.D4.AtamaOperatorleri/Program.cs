using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D4.AtamaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * = atama işlemi gerçekleştirir. 
             * +=  
             * -=
             * /=
             * *=
             * 
             */

            #region = operatörü kullanımı 
            int sayi1 = 10;
            #endregion

            #region += operatörü kullanımı 
            sayi1 += 2; // sayi1 = sayi1 + 2;
            Console.WriteLine(sayi1);
            #endregion

            #region -= operatörü kullanımı 
            sayi1 -= 2;
            Console.WriteLine(sayi1);
            #endregion

            #region *= operatörü kullanımı 
            sayi1 *= 2;
            Console.WriteLine(sayi1);
            #endregion

            #region /= operatörü kullanımı 
            sayi1 /= 2;
            Console.WriteLine(sayi1);
            #endregion
        }
    }
}
