using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D1.ForGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü genel kullanımı 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ben bir for döngüsüyüm");
            }
            #endregion
            Console.Clear();
            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdıralım. 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ". tekrar !");
            }
            #endregion
            Console.Clear();
            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım. 
            for (int sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    Console.WriteLine(sayac + " - çift sayıdır !");
                }
            }
            #endregion
            Console.Clear();
            #region Küçük ödev : 1 - 100 arasındaki çift sayıların toplamı nedir ? 
            int toplam = 0;
            for (int sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    // toplam = toplam + sayac;
                    toplam += sayac;
                }
            }
            Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı : {0}", toplam);
            #endregion

            Console.Clear();

            #region Kullanıcı ekran üzerinden bir sayı girişi yapacak . (5) Girilenn sayısının faktöriyel hesabını alıp ekrana yazdıralım. 
            //string kullaniciGelenDeger = string.Empty;
            //int kullaniciGelenDegerInt = 0;
            //int faktoriyelHesapla = 1;

            //Console.WriteLine("Lütfen faktöriyel hesabı yapmak istediğiniz değeri ekrana yazınız");
            //kullaniciGelenDeger = Console.ReadLine();
            //kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);

            //for (int i = kullaniciGelenDegerInt; i > 1; i--)
            //{
            //    faktoriyelHesapla = faktoriyelHesapla * i;
            //    //faktoriyelHesapla *= i;
            //}
            //Console.WriteLine("{0} değerinin faktöriyel sonucu : {1}", kullaniciGelenDeger, faktoriyelHesapla);
            #endregion
            Console.Clear();
            #region Sonsuz döngü oluşturmak
            //int sonsuzDonguSayac = 0;
            //for (; ; )
            //{
            //    sonsuzDonguSayac++;
            //    //break anahtar kelimesi;
            //    //if (sonsuzDonguSayac == 2)
            //    //    break;
            //    // continue anahtar kelimesi
            //    if (sonsuzDonguSayac == 2)
            //        continue;

            //    Console.WriteLine(sonsuzDonguSayac);

            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            //}
            #endregion
            Console.Clear();
            #region iç içe for döngüsü kullanımı 
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.Clear();
            #region Ödev : Çarpım Tablosu 
            /*
             * 1*1 = 1   
             * 1*2 = 2   
             * 1*3 = 3   
             * 1*4 = 4   
             * 1*5 = 5   
             * 1*6 = 6   
             * .         
             * .         
             * 1*10 = 10
             * 
             * 2*1 = 2
             */

            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    int carpimSonuc = i * y;
                    Console.Write("{0}*{1}={2}\t", i, y, carpimSonuc);
                }
                Console.WriteLine();
            }

            #endregion

            Console.Clear();
        }
    }
}
