using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S2.D3.MantiksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * && : Ve operatörü 
             * || : veya operatörü 
             */

            int sayi1 = 50;
            int sayi2 = 5;
            int sayi3 = 20;

            #region Ve operatoru Tanım 
            bool veOperatoruSonuc = sayi1 > sayi2 && sayi1 < sayi3;
            /*
             * True - True = True 
             * True - False = False 
             * False - True = False 
             */
            #endregion

            #region veya operatörü
            bool veyaOperatoruSonuc = sayi1 < sayi2 || sayi1 < sayi3;
            /*
             * True - False = True 
             * False - True = True 
             * False - False = False 
             * <= >=
             */ 
            #endregion
        }
    }
}
