using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12254401254";
            M1.musteriNumara = "MS123";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.DogumTarih = DateTime.Parse("02.11.1984");

            MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>();
            MusteriGeneric1.id = 1;
            MusteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();
            MusteriGeneric2.musteriNumarasiAl();



        }
    }
}
