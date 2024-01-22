using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D1.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            // Nasıl değer ekleyebiliriz. 
            // 1 2 3 4 ... 10 
            // 0 1 2 3 4 5 6 7 8 9 10
            /*
             * 5 elemanlı bir dizi oluşturuduğum zaman 
             * 
             * [0]
             * [1]
             */

            ogrenciIsimListesi[0] = "Cengiz Atilla";
            ogrenciIsimListesi[1] = "Ahmet Yavuz";
            ogrenciIsimListesi[2] = "Mustafa SEL";
            ogrenciIsimListesi[3] = "Hatice GÖK";
            ogrenciIsimListesi[4] = "Tayfun SEL";

            // Console.WriteLine(ogrenciIsimListesi[1]);

            #region oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım. 
            foreach(string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }

            Console.Clear();

            for(int i = 0; i<ogrenciIsimListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsim);
            }
            #endregion
            Console.Clear();
        }
    }
}
