using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object => ToString();
            /*
             * Musteri M1 = new Musteri();
             * Object => Musteri 
             *           M1.Tostring(); 
             * 
             * Namespace.Musteri 
             * 
             * 
             */

            Musteri M1 = new Musteri();
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            string toStringMesaj =  M1.ToString();
            Console.WriteLine(toStringMesaj);

            
        }
    }
}
