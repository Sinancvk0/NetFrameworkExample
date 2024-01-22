using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılamasın ama değer okunabilsin.
             * Field değer ataması yapılsın ama değer okunamasın. 
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin. 
             */

            // Class 
            //  Field 
            //  Property
            //  Get & Set 

            // M1.emailAdres = "cengiz.atilla@hotmail.com"; ( Field ) 
           
            // Genel olarak kapsülleme konusuna giriş yaptık.
            //M1.EmailAdres = "cengiz.atilla@hotmail.com";
            //Console.Write(M1.EmailAdres);

            // 1. Field değer ataması yapılamasın ama değer okunabilsin.

            Console.WriteLine("Musteri Id Değeri = " + M1.ID.ToString());
            // M1.ID = 10;

            M1.TCKimlikNumarasi = "12254402599";
            string TC = M1.TCKimlikNumarasi;

            // isim ve soyisim 
            // isim ve soyisim [soyisim] = set 
            // email adresi .... 
            // email get cengiz.atilla@hotmail.com
            // set : private 

            M1.isim = "cengiz";
            M1.Soyisim = "atilla";
            Console.WriteLine(M1.EmailAdres);

        }
    }
}
