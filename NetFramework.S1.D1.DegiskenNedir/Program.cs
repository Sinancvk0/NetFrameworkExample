using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D1.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        { // üst işlem blok 

           



            // veritipi degiskenadi 
            string isim;
            isim = "Cengiz";

            Console.Write("Kullanıcı Adı :");
            Console.WriteLine(isim);

            // Ekran çıktısı : 
            // Kullanıcı Adı :Cengiz

            int i = 4;
            int y = i;

            Console.Write("i nin değeri :");
            Console.WriteLine(i);
            Console.Write("y nin değeri :");
            Console.WriteLine(y);

            y = 10;

            Console.Write("i nin değeri :");
            Console.WriteLine(i);
            Console.Write("y nin değeri :");
            Console.WriteLine(y);

            int sayi1 = 0;

            sayi1 = int.MinValue;
            Console.WriteLine("En düşük değer :");
            Console.WriteLine(sayi1);

            sayi1 = int.MaxValue;
            Console.WriteLine("En yüksek değer :");
            Console.WriteLine(sayi1);

            // bölüm sonunda bir ödev gelecek... 
            double sayi2 = double.MinValue;

            // alt işlem blok
            {

                int toplam = 30;
                Console.WriteLine(toplam);
                toplam = 40;

                sayi2 = 100;
            }

            Console.WriteLine(sayi2);


           

            Console.ReadLine();
        }
    }
}
