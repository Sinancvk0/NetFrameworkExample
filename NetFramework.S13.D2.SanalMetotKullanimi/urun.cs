using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    public class urun : baseClass
    {
        public urun()
        {
            Console.WriteLine("urun");
        }
        public override void ekranaYaz(string data)
        {
            Console.WriteLine("urun => " + data);
        }
    }
}
