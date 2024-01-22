using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "cengiz";
            m1.soyisim = "atilla";
            m1.emailAdres = "cengiz.atilla@hotmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("database yeni kayıt eklendi.");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
            int ogrencikayitsonuc = O1.yeniKayit(O1);

            if(ogrencikayitsonuc == 71777000)
            {

            }
            else if(ogrencikayitsonuc == 71777001)
            {

            }
            else if (ogrencikayitsonuc == 71777002)
            {

            }
            else if (ogrencikayitsonuc == 71777003)
            {

            }
            else if (ogrencikayitsonuc == 71777004)
            {

            }
            else
            {

            }




        }
    }
}
