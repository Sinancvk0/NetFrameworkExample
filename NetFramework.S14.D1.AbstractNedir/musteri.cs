using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    public class musteri : temelSinif
    {
        public int musteriID { get; set; }

        public musteri()
        {
            musteriID = 1;
        }

        public override void testAbstract()
        {
            Console.WriteLine("musteri => testAbstract");
        }
    }
}
