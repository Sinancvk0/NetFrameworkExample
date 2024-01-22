using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public interface Imusteri
    {
        //public Imusteri()
        //{

        //}
        // interface içerisinde ctor kullanılmaz..

        // field 

        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }


        // metot 

        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int id, string isim, string soyisim);
        int kayitSil(int id);


    }
}
