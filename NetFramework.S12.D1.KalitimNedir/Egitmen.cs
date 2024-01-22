using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public sealed class Egitmen:Personel
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        

        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metotu çalıştı");
            //IdAtamaIslemi

        }
    }
}
