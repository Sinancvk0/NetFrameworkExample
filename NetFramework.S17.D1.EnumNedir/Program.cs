using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.emailAdres = "cengiz.atilla@hotmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            int enumInt = (int)musteriReturnValue.kayitBasarisiz;
            Console.WriteLine(enumInt);

            //if (musteriKayitSonuc ==  musteriReturnValue.kayitBasarili)
            //{

            //}
        }
    }
}
