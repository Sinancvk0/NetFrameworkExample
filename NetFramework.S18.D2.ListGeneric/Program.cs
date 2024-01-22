using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList ) Generic versiyonu 

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            // <T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek . 

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            //listeGeneric.Add("uc");

            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Cengiz");
            isimler.Add("Atilla");
            isimler.Add("Hamza");
            //isimler.Add(123);

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            List<musteri> musteriListe = new List<musteri>();
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "cengiz",
                soyisim = "atilla"
            });

            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }



        }
    }
}
