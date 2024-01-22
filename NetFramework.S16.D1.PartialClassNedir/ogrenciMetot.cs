using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public partial class ogrenci
    {
        public int yeniKayit(ogrenci o)
        {

            /*
             * Kontrol işlemleri : sistem içerisinde öğrenci kayıtlı mı ? 71777000;
             * parametre kontrol işlemi : Giriş verileriniz hatalıdır. : 71777001;
             * try catch : 71777002; 
             * Başarılı : 71777003 
             * .
             * .
             * .
             * .
             * 71777014;
             * 
             */

            Console.WriteLine("Kayıt işlemi başarılı");
            return 1;
        }


        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("Ogrenci kayıt güncelleme başarılı");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("ogrenci silindi");
            return 1;
        }
    }
}
