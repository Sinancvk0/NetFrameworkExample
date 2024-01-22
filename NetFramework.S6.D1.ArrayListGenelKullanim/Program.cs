using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D1.ArrayListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 10 elemanlı ( string ) Arraylist içindeki değerleri Z-A olacak şekilde sıralayın 
            ArrayList OdevListe = new ArrayList();
            OdevListe.Add("Zeynep");
            OdevListe.Add("Özgür");
            OdevListe.Add("Yakup");
            OdevListe.Add("Ayşegül");
            OdevListe.Add("Hakan");
            OdevListe.Add("Cengiz");
            OdevListe.Add("Mustafa");
            OdevListe.Add("Lale");
            OdevListe.Add("Gökhan");
            OdevListe.Add("Selim");
            OdevListe.Add("Nilüfer");

            // Adım 1 : Tüm değerleri A-Z çevir. 
            OdevListe.Sort();
            OdevListe.Reverse();

            #endregion

            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            #region Tek Değer ekleme 
            A1.Add("Cengiz ATİLLA");

            Capacity = A1.Capacity;
            Count = A1.Count;

            A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme işlemi. 
            ArrayList A2 = new ArrayList();
            A2.Add("Yakup");
            A2.Add("Merve");
            A2.Add("Utkan");
            A1.AddRange(A2);
            #endregion

            #region Capacity & Count İnceleme
            Capacity = A1.Capacity;
            Count = A1.Count;
            #endregion

            #region Koleksiyon içindeki değere ulaşmak 
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Hamza Atilla";
            #endregion

            #region ArrayList Sıralama 

            // Dizinin mevcut elemanlarını ters olarak sıralama 
            A1.Remove(100);
            A1.Reverse();
            // A-Z Sıralama 
            A1.Sort();

            #endregion

            #region Koleksiyonlar yardımcı komutları 

            if (A1.Contains("Yakup"))
            {
                int IndexDegeri = A1.IndexOf("Yakup");
                A1.RemoveAt(IndexDegeri);
            }
           

            bool Kontrol1 = A1.Contains("Utkan");
            bool Kontrol2 = A1.Contains(900);

            object[] D1 = A1.ToArray();

            A1.Clear();
            A1.TrimToSize();

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("Hamza Atilla");

            #endregion

           















        }
    }
}
