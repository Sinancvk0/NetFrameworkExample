using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D3.ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;
            

            // 1. yol ama uzun bir yol ... 
            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            // 2. yol 
            sayilarim.AddRange(eklenecekData1);

            // ------------------------------------------------------------------------------

            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            sayilarim.TrimExcess(); // Count ve Capacity değerlerini eşitler. 

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;

            // Soru ? : sayilarim koleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyorum bunu nasıl yaparsınız. 

            sayilarim.ForEach(i => Console.WriteLine(i));
            // => ilgili koleksiyon içerisinde arama yap... 
            // => linq konusu list<T> içerisinde 

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3. index de bulunan değer : {0}", bulunanDeger);

            sayilarim.Insert(3, 100);

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i => i > 500);


            sayilarim.Sort(); // A-Z   1-N 
            sayilarim.Reverse(); // Z - A 


            int enYuksekDeger =  sayilarim.Max();
            int enDusukDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum();


            // Uygulama Alanı => Bölüm 
            // List<T> Uygulama - Windows Form // 1 saat

            bool silmeIslemiSonuc = sayilarim.Remove(100);
            int silinenAdet = sayilarim.RemoveAll(i => i > 3);
            sayilarim.RemoveAt(2);

            sayilarim.Clear();

        }
    }
}
