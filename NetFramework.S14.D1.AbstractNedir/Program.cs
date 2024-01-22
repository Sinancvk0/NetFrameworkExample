using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            superMusteri SP1 = new superMusteri();
            SP1.testAbstract();

            // temelSinif T1 = new temelSinif();
            musteri M1 = new musteri();
            M1.test();
            M1.testAbstract();
            

        }
    }
}
